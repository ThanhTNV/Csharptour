namespace BookManagerGUIForms
{
    partial class BookManagerMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSayHello = new Button();
            btnQuit = new Button();
            btnFillCountry = new Button();
            btnShowCountry = new Button();
            dgvBookList = new DataGridView();
            btnLoadBook = new Button();
            cboCountry = new ComboBox();
            label1 = new Label();
            btnCreateBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.FlatStyle = FlatStyle.Flat;
            btnSayHello.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSayHello.ForeColor = Color.Yellow;
            btnSayHello.Location = new Point(421, 12);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(168, 66);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(595, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(168, 66);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnFillCountry
            // 
            btnFillCountry.FlatStyle = FlatStyle.Flat;
            btnFillCountry.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFillCountry.ForeColor = Color.Yellow;
            btnFillCountry.Location = new Point(12, 12);
            btnFillCountry.Name = "btnFillCountry";
            btnFillCountry.Size = new Size(180, 66);
            btnFillCountry.TabIndex = 2;
            btnFillCountry.Text = "Fill Country";
            btnFillCountry.UseVisualStyleBackColor = true;
            btnFillCountry.Click += btnFillCountry_Click;
            // 
            // btnShowCountry
            // 
            btnShowCountry.FlatStyle = FlatStyle.Flat;
            btnShowCountry.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowCountry.ForeColor = Color.Yellow;
            btnShowCountry.Location = new Point(198, 12);
            btnShowCountry.Name = "btnShowCountry";
            btnShowCountry.Size = new Size(217, 66);
            btnShowCountry.TabIndex = 3;
            btnShowCountry.Text = "Show Country";
            btnShowCountry.UseVisualStyleBackColor = true;
            btnShowCountry.Click += btnShowCountry_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 204);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(901, 344);
            dgvBookList.TabIndex = 7;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            // 
            // btnLoadBook
            // 
            btnLoadBook.FlatStyle = FlatStyle.Flat;
            btnLoadBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadBook.ForeColor = Color.Yellow;
            btnLoadBook.Location = new Point(933, 204);
            btnLoadBook.Name = "btnLoadBook";
            btnLoadBook.Size = new Size(191, 66);
            btnLoadBook.TabIndex = 8;
            btnLoadBook.Text = "Load Book";
            btnLoadBook.UseVisualStyleBackColor = true;
            btnLoadBook.Click += btnLoadBook_Click;
            // 
            // cboCountry
            // 
            cboCountry.BackColor = Color.FromArgb(255, 128, 128);
            cboCountry.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCountry.ForeColor = Color.Yellow;
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(457, 89);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(473, 45);
            cboCountry.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(234, 92);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 6;
            label1.Text = "Select Country:";
            label1.Click += label1_Click;
            // 
            // btnCreateBook
            // 
            btnCreateBook.FlatStyle = FlatStyle.Flat;
            btnCreateBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateBook.ForeColor = Color.Yellow;
            btnCreateBook.Location = new Point(933, 286);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(191, 66);
            btnCreateBook.TabIndex = 9;
            btnCreateBook.Text = "Create Book";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Red;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1003, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // BookManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1148, 575);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCreateBook);
            Controls.Add(btnLoadBook);
            Controls.Add(dgvBookList);
            Controls.Add(label1);
            Controls.Add(cboCountry);
            Controls.Add(btnShowCountry);
            Controls.Add(btnFillCountry);
            Controls.Add(btnQuit);
            Controls.Add(btnSayHello);
            Name = "BookManagerMainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnQuit;
        private Button btnFillCountry;
        private Button btnShowCountry;
        private DataGridView dgvBookList;
        private Button btnLoadBook;
        private ComboBox cboCountry;
        private Label label1;
        private Button btnCreateBook;
        private DateTimePicker dateTimePicker1;
    }
}
