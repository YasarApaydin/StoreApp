using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Components
{
    public class CategoriesListViewComponent:ViewComponent
    {

        private readonly IStoreRepository repository;
        public CategoriesListViewComponent(IStoreRepository _repository)
        {
            repository = _repository;
            
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Categories.Select(x => new CategoryViewModel
            {
               
                Id = x.Id,
                Name = x.Name,
                Url = x.Url
            }).ToList()

                );
        }


    }
}
