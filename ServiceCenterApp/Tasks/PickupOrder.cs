using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Tasks
{
    internal class PickupOrder : SimpleOrder
    {
        public override int Price
        {
            get
            {
                int sumprice = 0;
                for (int i = 0; i < Basket.Count; i++)
                {
                    sumprice += Basket[i].PricePr;
                }
                return sumprice;
            }
        }
        
        public PickupOrder(string name, int orderid, string phonenumber, bool ispickup, string waytoget, List<Product> basket, DateTime time) : base(name, orderid, phonenumber, ispickup, waytoget, basket, time)
        {
        }
    }
}
