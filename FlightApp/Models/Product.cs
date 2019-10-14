using FlightApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Product
    {
        #region Fields
        private double _productPrice;
        private string _productName;
        private string _productDescription;
        private Category _productCategory;
            
        #endregion

        #region Properties
        public int ProductId { get; set; }

        public double ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("please set a productprice");
                _productPrice = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("please set a productname");
                _productName = value;
            }
        }

        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("please set a productdescription");
                _productDescription = value;
            }
        }
        public Category ProductCategory
        {
            get
            {
                return _productCategory;
            }
            set
            {
                if (value == Category.Undefined)
                    throw new ArgumentException("please select a type");
                _productCategory = value;
            }
        }
        #endregion

        protected Product()
        {

        }

        public Product(string name, string desc, double price, Category category): this()
        {
            ProductName = name;
            ProductDescription = desc;
            ProductPrice = price;
            ProductCategory = category;
        }
    }
}
