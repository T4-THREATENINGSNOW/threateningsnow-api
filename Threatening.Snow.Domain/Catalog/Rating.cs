using System;

namespace Threatening.Snow.Domain.Catalog
{
    public class Rating
    {
        public int Id { get; set; } 
        public int Stars {get; set;}
        public string UserName {get; set;}
        public string Review {get; set;}
    }
}