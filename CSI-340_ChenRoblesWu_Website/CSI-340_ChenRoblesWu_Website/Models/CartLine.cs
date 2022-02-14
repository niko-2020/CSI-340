using CSI_340_ChenRoblesWu_Website.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public void AddItem(BookModel book, int quantity)
        {
            CartLine line = Lines
            .Where(p => p.book.Book_id == book.Book_id)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(BookModel book) =>
        Lines.RemoveAll(l => l.book.Book_id == book.Book_id);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.book.Book_id * e.Quantity);
        public void Clear() => Lines.Clear();
    } 

public class CartLine
    {
        [Key]
        public int customer_id { get; set; }    
        public BookModel book { get; set; }
        public int Quantity { get; set; }


    }

}