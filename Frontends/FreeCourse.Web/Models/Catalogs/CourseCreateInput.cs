using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Kurs Kategori")]
        public string CategoryId { get; set; }
        public string UserId { get; set; }
        
        [Display(Name = "Kurs İsmi")]
        public string Name { get; set; }
        
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Display(Name = "Kurs Açıklaması")]
        public string Description { get; set; }

        public string Picture { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Display(Name = "Kurs Resmi")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
