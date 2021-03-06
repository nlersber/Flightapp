﻿using FlightApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Orderline
    {
        #region Fields
        private Product _product;
        private int _numberOfProducts;
        private Passenger _passenger;
        #endregion

        #region Properties
        public int OrderLineId { get; set; }

        public Product Product
        {
            get
            {
                return _product;
            }
            set
            {
                if (value.Equals(null))
                    throw new ArgumentException("please select a product");
                _product = value;
            }
        }

        public int NumberOfProductItems
        {
            get
            {
                return _numberOfProducts;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("select the amount");
                _numberOfProducts = value;
            }
        }

        public Passenger Passenger
        {
            get
            {
                return _passenger;
            }
            set
            {
                if (value.Equals(null))
                    throw new ArgumentException("there must be a passenger specified for the order");
                _passenger = value;
            }
        }


        public double TotalPrice => Product.ProductPrice * NumberOfProductItems;
        public DateTime TimeOfOrderPlacement => DateTime.Now;
        #endregion

        protected Orderline()
        {

        }

        public Orderline(Product p, int amount, Passenger passenger): this()
        {
            Product = p;
            NumberOfProductItems = amount;
            Passenger = passenger;
        }
    }
}
