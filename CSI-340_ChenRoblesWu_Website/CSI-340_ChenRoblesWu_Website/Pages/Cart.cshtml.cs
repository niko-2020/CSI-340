using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSI_340_ChenRoblesWu_Website.Infrastructure;
using CSI_340_ChenRoblesWu_Website.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace CSI_340_ChenRoblesWu_Website.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
          
        }
        public IActionResult OnPost(long productId, string returnUrl)
        {
            BookModel book = repository.Books
                .FirstOrDefault(p => p.Book_id == productId);
            
            Cart.AddItem(book, 1);
            
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.book.Book_id == productId).book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }        
    }
}
