using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers
{
    public class HomeController : Controller
    {

        public int pageSize = 3;
        private readonly IStoreRepository storeRepository;
        private readonly IMapper mapper;
        public HomeController(IStoreRepository  _storeRepository, IMapper _mapper)
        {
            mapper = _mapper;

            storeRepository = _storeRepository;
        }
        public IActionResult Index(string category,int page = 1)
        {
          
            return View(new ProductListViewModel
            {
                Products = storeRepository.GetProductByCategory(category,page,pageSize).Select(product => mapper.Map<ProductViewModel>(product)),
                SayfaBilgisi= new SayfaBilgisi
                {SayfaBasinaDusenOge = pageSize,
                CurrentPage =page,
                    ToplamOge =storeRepository.GetProductCount(category)
                }
               
            });
        }

    }
}
