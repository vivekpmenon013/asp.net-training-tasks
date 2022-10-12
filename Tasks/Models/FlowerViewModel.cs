using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class FlowerViewModel
    {
        [Required(ErrorMessage = "Select the flower to display the label")]
        public string SelectedFlower { get; set; }
        public IEnumerable<string> Flowers => new[]
        {
            "Sunflower",
            "Flower 2",
            "Flower 3"
        };
    }
}