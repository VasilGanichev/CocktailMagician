﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailMagician.Data.Entities
{
    public class Bar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Picture { get; set; }
        public bool IsHidden { get; set; }
        public int CocktailID { get; set; }
        public List<BarCocktail> BarCocktails {get; set;}
        public int ReviewID { get; set; }
        public List<Review> Reviews { get; set; }

        
    }
}
