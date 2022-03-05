using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
namespace Views.Shared.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket Basket;
        public CartSummaryViewComponent(Basket basketService)
        {
            Basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(Basket);
        }
    }
}
