using EntityFramworkLab2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkLab2
{
    public partial class Form1 : Form
    {
        private readonly LogContext db;

        public Form1()
        {
            InitializeComponent();
            db = new LogContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            Author user = db.Authors.FirstOrDefault(a => a.Email == email && a.Password == password);
            if(user != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Profile profileForm = new Profile(user);
                this.Hide();
                profileForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
