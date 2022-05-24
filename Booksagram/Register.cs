using Booksagram.Helpers;
using Booksagram.Models;
using System;
using System.Windows.Forms;

namespace Booksagram.DBContext
{
    public partial class Register : Form
    {
        private readonly BooksagramDbContext booksagramDBContext;
        public Register(BooksagramDbContext booksagramDBContext)
        {
            InitializeComponent();
            this.booksagramDBContext = booksagramDBContext;
            this.password_textbox.PasswordChar = '*';
            this.repassword_textbox.PasswordChar = '*';
        }

        private async void register_button_Click(object sender, EventArgs e)
        {
            string username = this.username_textbox.Text;
            string password = this.password_textbox.Text;
            string repassword = this.repassword_textbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repassword))
            {
                MessageBox.Show("Please fill all inputs.");
                return;
            }

            if (password != repassword)
            {
                MessageBox.Show("Password doesn't match!");
                return;
            }

            /* string salt = PasswordManager.GenerateSalt();
             string hashedPassword = PasswordManager.HashPassword(password, salt);

             User user = new User()
             {
                 Username = username,
                 PasswordHash = hashedPassword,
                 Salt = salt
             };

             await this.booksagramDBContext.Users.AddAsync(user);
             await this.booksagramDBContext.SaveChangesAsync();*/

            User user = new User();
            user.Username = username;
            var salt = PasswordManager.GenerateSalt();
            user.Salt = salt;
            user.PasswordHash = PasswordManager.HashPassword(password, salt);
            this.booksagramDBContext.User.Add(user);
            this.booksagramDBContext.SaveChanges();
            MessageBox.Show("Great Success!");
            HomeForm homeform = new HomeForm(booksagramDBContext);
            homeform.Show();
            Hide();
        }

    }
}
