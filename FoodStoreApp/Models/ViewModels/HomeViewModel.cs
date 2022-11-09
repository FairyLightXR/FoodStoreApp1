﻿using Microsoft.AspNetCore.Mvc.Rendering;


namespace FoodStoreApp.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
