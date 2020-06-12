using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Model
{
    public class PieRepository:IpieRepository
    {
        private readonly AppDbContext _appDbContext;

        //constructor injection we can access appDbContext
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //public string GetImageUrl()
        //{
        //    byte[] imageArray = System.IO.File.ReadAllBytes(@"wwwroot/images/cherryPie.jpg");
        //    string base64ImageRepresentation = Convert.ToBase64String(imageArray);

        //    return base64ImageRepresentation;

        //}

        //Interface Implementation for quering data from DbContext
        public IEnumerable<Pie> AllPies 
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category); //Querying data
            
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek 
        {
            get 
            {
                return _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOftheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
