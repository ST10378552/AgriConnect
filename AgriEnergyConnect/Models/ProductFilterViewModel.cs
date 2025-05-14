using AgriEnergyConnect.Models;
using System;

namespace AgriEnergyConnect.ViewModels
{
    public class ProductFilterViewModel
    {
        public string SearchString { get; set; }
        public string Category { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public List<Product> Results { get; set; } = new List<Product>();
    }
}