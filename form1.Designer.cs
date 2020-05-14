namespace Library2._0
{
    partial class Form1
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
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.author_name = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.book_id = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.book_price = new System.Windows.Forms.TextBox();
            this.book_quant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.book_author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(12, 225);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(483, 82);
            this.BooksListBox.TabIndex = 0;
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(82, 199);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(146, 20);
            this.author_name.TabIndex = 1;
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(4, 202);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(67, 13);
            this.BookName.TabIndex = 2;
            this.BookName.Text = "Author name";
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(244, 194);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(99, 28);
            this.SearchBook.TabIndex = 3;
            this.SearchBook.Text = "Search Books";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Author Filter";
            // 
            // DeleteBook
            // 
            this.DeleteBook.Location = new System.Drawing.Point(411, 123);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(84, 38);
            this.DeleteBook.TabIndex = 7;
            this.DeleteBook.Text = "Delete Book";
            this.DeleteBook.UseVisualStyleBackColor = true;
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(411, 74);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(84, 38);
            this.UpdateBook.TabIndex = 8;
            this.UpdateBook.Text = "Update Book";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(411, 32);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(84, 33);
            this.AddBook.TabIndex = 9;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(62, 32);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(78, 20);
            this.book_id.TabIndex = 10;
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(62, 58);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(186, 20);
            this.book_name.TabIndex = 11;
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(62, 84);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(186, 20);
            this.book_price.TabIndex = 12;
            // 
            // book_quant
            // 
            this.book_quant.Location = new System.Drawing.Point(62, 110);
            this.book_quant.Name = "book_quant";
            this.book_quant.Size = new System.Drawing.Size(186, 20);
            this.book_quant.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Add book data";
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(62, 141);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(186, 20);
            this.book_author.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_quant);
            this.Controls.Add(this.book_price);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.BooksListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox book_price;
        private System.Windows.Forms.TextBox book_quant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.Label label7;
    }
}

