namespace Booksagram
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.logout_btn = new System.Windows.Forms.Button();
            this.GreetingMessage = new System.Windows.Forms.Label();
            this.new_book_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_btn.Location = new System.Drawing.Point(310, 322);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(117, 52);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // GreetingMessage
            // 
            this.GreetingMessage.AutoSize = true;
            this.GreetingMessage.Location = new System.Drawing.Point(342, 122);
            this.GreetingMessage.Name = "GreetingMessage";
            this.GreetingMessage.Size = new System.Drawing.Size(44, 16);
            this.GreetingMessage.TabIndex = 1;
            this.GreetingMessage.Text = "Hello User!";
            // 
            // new_book_btn
            // 
            this.new_book_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_book_btn.Location = new System.Drawing.Point(310, 213);
            this.new_book_btn.Name = "new_book_btn";
            this.new_book_btn.Size = new System.Drawing.Size(111, 70);
            this.new_book_btn.TabIndex = 2;
            this.new_book_btn.Text = "New Book";
            this.new_book_btn.UseVisualStyleBackColor = true;
            this.new_book_btn.Click += new System.EventHandler(this.new_book_btn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_book_btn);
            this.Controls.Add(this.GreetingMessage);
            this.Controls.Add(this.logout_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label GreetingMessage;
        private System.Windows.Forms.Button new_book_btn;
    }
}