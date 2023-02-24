using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]

    public class CarrinhoViewComponents : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponents()
        {
            ItensCarrinho = 3;
        }
     
        public async Task<IViewComponentResult> InvokeAsync() 
        { 
            return View(ItensCarrinho); 

        }

    }
}
