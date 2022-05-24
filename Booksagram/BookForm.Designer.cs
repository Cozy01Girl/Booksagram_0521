namespace Booksagram
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.author_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.RichTextBox();
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title_textbox
            // 
            this.title_textbox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_textbox.Location = new System.Drawing.Point(68, 55);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(223, 40);
            this.title_textbox.TabIndex = 0;
            // 
            // author_textbox
            // 
            this.author_textbox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_textbox.Location = new System.Drawing.Point(68, 159);
            this.author_textbox.Name = "author_textbox";
            this.author_textbox.Size = new System.Drawing.Size(223, 40);
            this.author_textbox.TabIndex = 1;
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_textbox.Location = new System.Drawing.Point(68, 268);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(223, 198);
            this.description_textbox.TabIndex = 3;
            this.description_textbox.Text = "";
            // 
            // BookGridView
            // 
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.Location = new System.Drawing.Point(335, 55);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.RowHeadersWidth = 51;
            this.BookGridView.RowTemplate.Height = 24;
            this.BookGridView.Size = new System.Drawing.Size(665, 411);
            this.BookGridView.TabIndex = 4;
            this.BookGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(142, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(111, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create_button.Location = new System.Drawing.Point(32, 492);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(104, 41);
            this.create_button.TabIndex = 8;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_button.Location = new System.Drawing.Point(168, 492);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(112, 42);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Update ";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // del_btn
            // 
            this.del_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_btn.Location = new System.Drawing.Point(335, 491);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(112, 42);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1059, 559);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookGridView);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.author_textbox);
            this.Controls.Add(this.title_textbox);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "Diary for storyes";
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.TextBox author_textbox;
        private System.Windows.Forms.RichTextBox description_textbox;
        private System.Windows.Forms.DataGridView BookGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button del_btn;
    }
}