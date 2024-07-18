﻿using CaterServMongoDb.Dtos.CategoryDtos;

namespace CaterServMongoDb.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string CategoryName { get; set; }

        public ResultCategoryDto Category { get; set; }
    }
}