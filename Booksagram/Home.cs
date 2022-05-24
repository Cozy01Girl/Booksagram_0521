using Booksagram.DBContext;
using Booksagram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booksagram
{
    public partial class HomeForm : Form
    {
        private readonly BooksagramDbContext booksagramDbContext;
        private string username;
        private Guid id;

        public HomeForm(BooksagramDbContext dbContext, Guid id, string username)
        {
            this.booksagramDbContext = dbContext;
            InitializeComponent();
            this.username = username;
            this.id = id;
            this.GreetingMessage.Text = $"Hello, {username}!";
        }
        private void logout_btn_Click(object sender, EventArgs e)
{
            Join joinform = new Join(booksagramDbContext);
            joinform.Show();
            this.username = "";
            this.Hide();
        }

        private void new_book_btn_Click(object sender, EventArgs e)
        {
            BookForm bookform = new BookForm(booksagramDbContext);
            bookform.Show();
            this.Hide();
        }
    }
}
