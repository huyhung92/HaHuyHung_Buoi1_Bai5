namespace HaHuyHung_Buoi1_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(txtso.Text);
            if (n == 0)
            {
                txtkq.Text = "Không";
            }
            else if (n == 1)
            {
                txtkq.Text = "Một";
            }
            else if (n == 2)
            {
                txtkq.Text = "Hai";
            }
            else if (n == 3)
            {
                txtkq.Text = "Ba";
            }
            else if (n == 4)
            {
                txtkq.Text = "Bốn";
            }
            else if (n == 5)
            {
                txtkq.Text = "Năm";
            }
            else if (n == 6)
            {
                txtkq.Text = "Sáu";
            }
            else if (n == 7)
            {
                txtkq.Text = "Bảy";
            }
            else if (n == 8)
            {
                txtkq.Text = "Tám";
            }
            else
            {
                txtkq.Text = "Chín";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
