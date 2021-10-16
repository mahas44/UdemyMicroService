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
        [Required]
        public string CategoryId { get; set; }
        public string UserId { get; set; }
        
        [Display(Name = "Kurs İsmi")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Fiyat")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Kurs Açıklaması")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Kurs Resmi")]
        public string Picture { get; set; }
        public FeatureViewModel Feature { get; set; }
    }
}
