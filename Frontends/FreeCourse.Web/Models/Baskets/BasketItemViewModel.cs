using System;

namespace FreeCourse.Web.Models.Baskets
{
    public class BasketItemViewModel
    {
        public int Quantity { get; set; } = 1;
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        private decimal? DiscountappliedPrice { get; set; }
        
        public decimal GetCurrentPrice
        {
            get => DiscountappliedPrice != null ? DiscountappliedPrice.Value : Price;
        }

        public void AppliedDiscount(decimal discountPrice)
        {
            DiscountappliedPrice = discountPrice;
        }
    }
}