using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library2._0.AcessMethods;

namespace Library2._0
{
    public partial class Form1 : Form
    {
        //lista de livros para ser adicionado no filtro
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();

            UpdateBinding();
        }
         
        private void UpdateBinding()
        {
            BooksListBox.DataSource = books;
            BooksListBox.DisplayMember = "FullBook";
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            LibraryAccess db = new LibraryAccess();

            books = db.GetBooks(author_name.Text);

            UpdateBinding();
         }
        private void AddBook_Click(object sender, EventArgs e)
        {
            LibraryAccess db = new LibraryAccess();

            //CONVERTENDO .Text PARA NUMERICO
            int b_id = int.Parse(book_id.Text);
            float b_price = float.Parse(book_price.Text);
            int b_quant = int.Parse(book_quant.Text);
            
            db.AddBook(b_id, book_name.Text, b_price, b_quant, book_author.Text);
           
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
