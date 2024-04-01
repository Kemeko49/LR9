using Microsoft.AspNetCore.Mvc;


    public class TableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }