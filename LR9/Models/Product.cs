﻿
    public class Product
    {
        static int productsAmount = 1;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Product(string name, double price, DateTime createdDateTime)
        {
            Id = productsAmount++;
            Name = name;
            Price = price;
            CreatedDateTime = createdDateTime;
        }
    }

