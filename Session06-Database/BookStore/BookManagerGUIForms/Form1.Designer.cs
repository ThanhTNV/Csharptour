namespace BookManagerGUIForms
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            cboCountry = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(421, 12);
            button1.Name = "button1";
            button1.Size = new Size(168, 66);
            button1.TabIndex = 0;
            button1.Text = "Say Hello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(595, 12);
            button2.Name = "button2";
            button2.Size = new Size(168, 66);
            button2.TabIndex = 1;
            button2.Text = "QUIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(180, 66);
            button3.TabIndex = 2;
            button3.Text = "Fill Country";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Yellow;
            button4.Location = new Point(198, 12);
            button4.Name = "button4";
            button4.Size = new Size(217, 66);
            button4.TabIndex = 3;
            button4.Text = "Show Country";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cboCountry
            // 
            cboCountry.BackColor = SystemColors.Window;
            cboCountry.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCountry.ForeColor = Color.Yellow;
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(235, 156);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(473, 45);
            cboCountry.TabIndex = 5;
            cboCountry.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 159);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 6;
            label1.Text = "Select Country:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(940, 575);
            Controls.Add(label1);
            Controls.Add(cboCountry);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox cboCountry;
        private Label label1;
    }
}
