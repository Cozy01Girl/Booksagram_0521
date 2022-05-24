using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booksagram.DBContext;
using Booksagram.Helpers;
using Booksagram.Models;
using Microsoft.EntityFrameworkCore;

namespace Booksagram
{
    public partial class Join : Form
    {
        private readonly BooksagramDbContext booksagramDBContext;
        public Join(BooksagramDbContext booksagramDBContext)
        { 
            this.booksagramDBContext = booksagramDBContext;
            InitializeComponent();
            this.password_textbox.PasswordChar = '*';
        }

        private async void Join_Btn_Click(object sender, EventArgs e)
        {
            string username = this.username_textbox.Text;
            string password = this.password_textbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please, fill all inputs!");
                return;
            }

            User user = await booksagramDBContext.User.SingleOrDefaultAsync(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("This user doesn't exist!");
                return;
            }

            string hashedPassword = PasswordManager.HashPassword(password, user.Salt);

            if (hashedPassword != user.PasswordHash)
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            HomeForm homeform = new HomeForm(booksagramDBContext, user.Id);
            homeform.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register(booksagramDBContext);
            registerForm.Show();
            this.Hide();
        }

    }
}
