using Booksagram.DBContext;
using Booksagram.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class BookForm : Form
    {
        private readonly BooksagramDbContext booksagramDbContext;
        private readonly int userId;
        private int bookId;
        public BookForm(BooksagramDbContext booksagramDbContext, int userId)
        {
            this.booksagramDbContext = booksagramDbContext;
            this.userId = userId;
            InitializeComponent();
            DisplayForm();
            PopulateForm();
        }

        public void DisplayForm()
        {
            this.BookGridView.ColumnCount = 6;
            this.BookGridView.Columns[0].Name = "Id";
            this.BookGridView.Columns[1].Name = "Title";
            this.BookGridView.Columns[2].Name = "Author";
            this.BookGridView.Columns[3].Name = "Description";
            this.BookGridView.Columns[4].Name = "Created At";
            this.BookGridView.Columns[5].Name = "Creator";
        }
        private void ClearForm()
        {
            this.title_textbox.Text = "";
            this.author_textbox.Text = "";
            this.description_textbox.Text = "";
        }
        private void PopulateForm()
        {
            this.BookGridView.Rows.Clear();
            List<Book> books = booksagramDbContext.Books.Include(b => b.User).ToList();
            foreach (var book in books)
            {
                string[] currentRow = { book.Id.ToString(), book.Title, book.Author, book.Description, book.CreatedAt.ToString(), book.User.Username };
                this.BookGridView.Rows.Add(currentRow);
            }
        }

        private async void create_button_Click(object sender, EventArgs e)
        {
            string title = this.title_textbox.Text;
            string author = this.author_textbox.Text;
            string description = this.description_textbox.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please,fill all inputs!");
                return;
            }
            
            Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.UserId = userId;

            await this.booksagramDbContext.Books.AddAsync(book);
            await this.booksagramDbContext.SaveChangesAsync();  
            this.ClearForm();
            this.PopulateForm();
        }

        private void BookGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ClearForm();
            int rowIndex = e.RowIndex;
            int id = int.Parse(this.BookGridView.Rows[rowIndex].Cells[0].Value.ToString());
            this.bookId = id;
            var currentBook = this.booksagramDbContext.Books.Find(id);
            this.title_textbox.Text = currentBook.Title;
            this.author_textbox.Text = currentBook.Author;
            this.description_textbox.Text = currentBook.Description;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            var book = this.booksagramDbContext.Books.Find(bookId);
            book.Title = this.title_textbox.Text;
            book.Author = this.author_textbox.Text;
            book.Description= this.description_textbox.Text;
            this.booksagramDbContext.Update(book);
            this.booksagramDbContext.SaveChanges();
            this.ClearForm();
            this.PopulateForm();
        }
    }
}
