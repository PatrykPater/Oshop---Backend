﻿namespace Service.Dto
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
