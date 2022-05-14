using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PieApplication.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository =new MockCategoryRepository();  
        public IEnumerable<Pie> AllPies =>
            new List<Pie> { 
            new Pie { Id=1, Name="strawaberry Pie",Price=15.59M,ShortDescription="strawberrry with cake",LongDescription="good stawberr with cake with sauce",AllegryInformation="",CategoryID=1,
            ImageUrl="",imageThmubnailUrl="",IsPieOfTheWeek=true,category=_categoryRepository.AllCategory.FirstOrDefault(c=>c.CategoryId == 1)},
            new Pie { Id=2, Name="cheese cake",Price=20.59M,ShortDescription="",LongDescription="",AllegryInformation="",CategoryID=2,
            ImageUrl="",imageThmubnailUrl="",IsPieOfTheWeek=true,category=_categoryRepository.AllCategory.FirstOrDefault(c=>c.CategoryId == 2)},
            new Pie { Id=3, Name="Rhurbab Pie",Price=25.59M,ShortDescription="",LongDescription="",AllegryInformation="",CategoryID=3,
            ImageUrl="",imageThmubnailUrl="",IsPieOfTheWeek=true,category=_categoryRepository.AllCategory.FirstOrDefault(c=>c.CategoryId == 3)}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieByID(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
