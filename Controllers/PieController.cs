using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using PieShop.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieController : Controller
    {
        private AppDbContext _appDbContext;
        private readonly IpieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IpieRepository pieRepository, ICategoryRepository categoryRepository,AppDbContext appDbContext)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }
        // GET: api/<PieApiController>
        [HttpGet]
        //public ViewResult List()
        //{
        //    PiesListViewModel piesListViewModel = new PiesListViewModel();
        //    piesListViewModel.Pies = _pieRepository.AllPies;
        //    piesListViewModel.CurrentCategory = "Cheese cakes";
        //    //to get the html view in response 
        //    return View(piesListViewModel);
        //}


        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }

        // GET api/<PieApiController>/5
        [HttpGet("{id}")]
        public IActionResult Details(int id) 
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }

     



   
        //public Pie Get(int id)
        //{
        //    var pie = _appDbContext.Pies.Find(id);
        //    return pie;
        //}

        //// POST api/<PieApiController> for Category
        //[HttpPost]
        //public IActionResult Post([FromBody]  Category category)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    _appDbContext.Categories.Add(category);
        //    _appDbContext.SaveChanges(true);
        //    return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        //}

        //POST api/<PieApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Pie pie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _appDbContext.Pies.Add(pie);
            _appDbContext.SaveChanges(true);
            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        // PUT api/<PieApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pie pie)
        {
            var data=_appDbContext.Pies.FirstOrDefault(p => p.PieId == id);
            data.Price = pie.Price;
            _appDbContext.SaveChanges();
        }


        // DELETE api/<PieApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
