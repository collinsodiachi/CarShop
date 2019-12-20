using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Controllers.Resources
{
    public class MakeResources
    {
        public MakeResources()
        {
            Models = new Collection<ModelResources>();
        }
        public int Id { get; set; }
        [Required] 
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<ModelResources> Models { get; set; }
    }
}