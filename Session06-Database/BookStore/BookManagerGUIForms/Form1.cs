namespace BookManagerGUIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO BROOOOOOOOO", "Xin chào", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you wanna quit?", "BRO PLEASE, Don't QUIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Country> arr = new List<Country>();
            arr.Add(new Country() { CountryCode = 84, Name = "VietNam" });
            arr.Add(new Country() { CountryCode = 1, Name = "USA" });
            arr.Add(new Country() { CountryCode = 44, Name = "United Kingdom" });

            cboCountry.DataSource = arr;
            cboCountry.DisplayMember = "Name"; // SHOW mỗi Name thôi, ẩn CountryCode đi
            cboCountry.ValueMember = "CountryCode"; //chọn tên quốc gia, nhưng cái ta cần là mã quốc gia
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the country code: " + cboCountry.SelectedValue);
        }
    }
}
