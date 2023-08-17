using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Tasks
{
    public class Product
    {
        private string NName { get; }

        private string Description { get; }

        public int PricePr { get; set; }

        public Product(string name, string description, int priceob)
        {
            NName = name;
            Description = description;
            PricePr = priceob;
        }

    }
}
