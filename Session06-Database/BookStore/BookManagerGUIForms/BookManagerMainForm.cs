using Repositories;
using Repositories.Entities;

namespace BookManagerGUIForms
{
    public partial class BookManagerMainForm : Form
    {
        public BookManagerMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO BROOOOOOOOO", "Xin chào", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you wanna quit?", "BRO PLEASE, Don't QUIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnFillCountry_Click(object sender, EventArgs e)
        {
            List<Country> arr = new List<Country>();
            arr.Add(new Country() { CountryCode = 84, Name = "VietNam" });
            arr.Add(new Country() { CountryCode = 1, Name = "USA" });
            arr.Add(new Country() { CountryCode = 44, Name = "United Kingdom" });

            cboCountry.DataSource = arr;
            cboCountry.DisplayMember = "Name"; // SHOW mỗi Name thôi, ẩn CountryCode đi
            cboCountry.ValueMember = "CountryCode"; //chọn tên quốc gia, nhưng cái ta cần là mã quốc gia
        }

        private void btnShowCountry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the country code: " + cboCountry.SelectedValue);
        }

        private void btnLoadBook_Click(object sender, EventArgs e)
        {
            //đổ table Book vào lưới dgvBookList - object dc render theo style table
            BookManagementDbContext bookContext = new BookManagementDbContext();
            dgvBookList.DataSource = bookContext.Books.ToList();
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            BookDetailForm detail = new BookDetailForm();//new mới tạo thôi, chưa render
            //detail.Text = "Tạo mới | Cập nhật sách";
            detail.ShowDialog();//render a.k.a. đẩy ra màn hình cho người xem

        }
    }
}
