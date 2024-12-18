namespace WinFormsApp1.Input
{
    partial class Registry
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
            txtTitle = new Label();
            txtBoxTitle = new TextBox();
            txtBoxAuthor = new TextBox();
            txtAuthor = new Label();
            txtAmount = new Label();
            txtBoxAmount = new TextBox();
            txtBoxPublicPrecious = new TextBox();
            txtPublicPrecious = new Label();
            txtBoxPreciousBook = new TextBox();
            txtPreciousBook = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Location = new Point(32, 50);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(83, 15);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Titulo del libro";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(133, 47);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(597, 23);
            txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxAuthor
            // 
            txtBoxAuthor.Location = new Point(133, 88);
            txtBoxAuthor.Name = "txtBoxAuthor";
            txtBoxAuthor.Size = new Size(597, 23);
            txtBoxAuthor.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.AutoSize = true;
            txtAuthor.Location = new Point(32, 91);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(83, 15);
            txtAuthor.TabIndex = 2;
            txtAuthor.Text = "Autor del libro";
            // 
            // txtAmount
            // 
            txtAmount.AutoSize = true;
            txtAmount.Location = new Point(32, 179);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(131, 15);
            txtAmount.TabIndex = 4;
            txtAmount.Text = "Cantidad de ejemplares";
            // 
            // txtBoxAmount
            // 
            txtBoxAmount.Location = new Point(167, 176);
            txtBoxAmount.Name = "txtBoxAmount";
            txtBoxAmount.Size = new Size(120, 23);
            txtBoxAmount.TabIndex = 5;
            // 
            // txtBoxPublicPrecious
            // 
            txtBoxPublicPrecious.Location = new Point(133, 130);
            txtBoxPublicPrecious.Name = "txtBoxPublicPrecious";
            txtBoxPublicPrecious.Size = new Size(182, 23);
            txtBoxPublicPrecious.TabIndex = 7;
            // 
            // txtPublicPrecious
            // 
            txtPublicPrecious.AutoSize = true;
            txtPublicPrecious.Location = new Point(32, 133);
            txtPublicPrecious.Name = "txtPublicPrecious";
            txtPublicPrecious.Size = new Size(95, 15);
            txtPublicPrecious.TabIndex = 6;
            txtPublicPrecious.Text = "Precio al publico";
            // 
            // txtBoxPreciousBook
            // 
            txtBoxPreciousBook.Location = new Point(458, 133);
            txtBoxPreciousBook.Name = "txtBoxPreciousBook";
            txtBoxPreciousBook.Size = new Size(182, 23);
            txtBoxPreciousBook.TabIndex = 9;
            // 
            // txtPreciousBook
            // 
            txtPreciousBook.AutoSize = true;
            txtPreciousBook.Location = new Point(357, 136);
            txtPreciousBook.Name = "txtPreciousBook";
            txtPreciousBook.Size = new Size(95, 15);
            txtPreciousBook.TabIndex = 8;
            txtPreciousBook.Text = "Precio al publico";
            // 
            // Registry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxPreciousBook);
            Controls.Add(txtPreciousBook);
            Controls.Add(txtBoxPublicPrecious);
            Controls.Add(txtPublicPrecious);
            Controls.Add(txtBoxAmount);
            Controls.Add(txtAmount);
            Controls.Add(txtBoxAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(txtBoxTitle);
            Controls.Add(txtTitle);
            Name = "Registry";
            Text = "Registrar libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitle;
        private TextBox txtBoxTitle;
        private TextBox txtBoxAuthor;
        private Label txtAuthor;
        private Label txtAmount;
        private TextBox txtBoxAmount;
        private TextBox txtBoxPublicPrecious;
        private Label txtPublicPrecious;
        private TextBox txtBoxPreciousBook;
        private Label txtPreciousBook;
    }
}