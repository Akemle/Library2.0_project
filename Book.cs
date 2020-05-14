using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2._0
{
    public class Book
    {
        public int book_id { get; set; }
        public string book_name { get; set; }
        public float book_price { get; set; }
        public int book_quant  { get; set; }
        public string book_author { get; set; }

    
        // utilizando uma propriedade para GET
        public string FullBook 
        { get
            {
                return $" BOOK: { book_name }  PRICE: {book_price} AMOUNT: {book_quant}";
            }
        }
    
    
    }
}
