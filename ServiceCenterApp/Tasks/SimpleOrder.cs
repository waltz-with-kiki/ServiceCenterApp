using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Tasks
{

    public enum StatusType
    {
        Processing,
        Completed,
        Waiting
    }

    public abstract class SimpleOrder
    {
        
        public List<Product> Basket { get; set; }

        public int OrderID { get; }
        public string NName { get; }

        public string PhoneNumber { get;}



        public DateTime Time { get; set; }

        public StatusType Status { get; set; }

        public string WayToGet { get;}

        public bool IsPickup { get; }


        public abstract int Price { get; }

        protected SimpleOrder(string name, int orderid, string phonenumber, bool ispickup, string waytoget, List<Product> basket, DateTime time)
        {
            if (name.Length == 0) throw new ArgumentException("invalid name. name must not be empty");

            if (orderid < 0) throw new ArgumentException("invalid id. id must be greater than or equal zero");

            if (waytoget.Length == 0) throw new ArgumentException("invalid waytoget");


            NName = name;
            OrderID = orderid;
            PhoneNumber = phonenumber;
            WayToGet = waytoget;
            Time = time;
            IsPickup = ispickup;
            Basket = basket;
            

        }


    }


}