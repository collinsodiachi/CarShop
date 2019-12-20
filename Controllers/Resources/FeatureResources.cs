using System.ComponentModel.DataAnnotations;

namespace CarShop.Controllers.Resources
{
    public class FeatureResources
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}