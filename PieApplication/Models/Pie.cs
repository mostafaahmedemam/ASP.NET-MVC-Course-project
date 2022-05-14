using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public class Pie
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string ShortDescription{ get; set; }
        public  string LongDescription { get; set; }    
        public string AllegryInformation { get; set; }  
        public decimal Price { get; set; }  
        public string ImageUrl { get; set; }    
        public string imageThmubnailUrl { get; set; }   
        public bool IsPieOfTheWeek  { get; set; }   
        public int CategoryID   { get; set; }
        public Category category { get; set; }

    }
}
