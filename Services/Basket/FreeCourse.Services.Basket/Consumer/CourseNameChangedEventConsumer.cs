using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FreeCourse.Services.Basket.Dtos;
using FreeCourse.Services.Basket.Services;
using FreeCourse.Shared.Messages;
using MassTransit;

namespace FreeCourse.Services.Basket
{
    public class CourseNameChangedEventConsumer : IConsumer<CourseNameChangedEvent>
    {
        private readonly RedisService _redisService;

        public CourseNameChangedEventConsumer(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task Consume(ConsumeContext<CourseNameChangedEvent> context)
        {
            var keys = _redisService.GetKeys();

            if (keys != null)
            {
                foreach (var key in keys)
                {
                    var basket = await _redisService.GetDatabase().StringGetAsync(key);

                    var basketDto = JsonSerializer.Deserialize<BasketDto>(basket);

                    basketDto.BasketItems.ForEach(x =>
                    {
                        x.CourseName = x.CourseId == context.Message.CourseId ? context.Message.UpdateName : x.CourseName;
                    });

                    await _redisService.GetDatabase().StringSetAsync(key, JsonSerializer.Serialize(basketDto));
                }
            }
        }
    }
}