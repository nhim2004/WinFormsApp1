using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        static string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,}$";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


            string email = textBox1.Text;
            if (string.IsNullOrWhiteSpace(emailPattern))
            {
                label5.Text = "Vui long nhap email";
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Visible = true;

            }

            else if (!Regex.IsMatch(email, emailPattern))
            {
                label5.Text = "Email khong hop le";
                label5.Visible = true;

            }
            else
            {
                label5.Visible = false;
            }

 
            if (string.IsNullOrWhiteSpace(passwordPattern))
            {
                label6.Text = "Vui long nhap mat khau";
                label6.Visible = true;

            }
            else
            {
                label6.Visible = false;
            }


            if (string.IsNullOrWhiteSpace(passwordPattern))
            {
                label7.Text = "Vui long nhap lai mat khau";
                label7.Visible = true;

            }
            else if (textBox2.Text != textBox3.Text)
            {
                label7.Text = "Mat khau khong khop";
                label7.Visible = true;
            }
            else
            {
                label7.Text = " ";
                label7.Visible = false;
            }


            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;


            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Mat khau khong hop le. Mat khau phai co it nhat 8 ky tu, bao gom chu thuong, chu hoa, so va ky tu dac biet.", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password != confirmPassword)
            {
                MessageBox.Show("Mat khau va nhap lai mat khau khong khop.", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dang ky thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }

            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
