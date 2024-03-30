using EntityFramworkLab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramworkLab2
{
    public partial class Profile : Form
    {
        private readonly Author _user;
        public Profile(Models.Author user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox1.Text = _user.UserName;
            textBox2.Text = _user.Email;
            textBox3.Text = _user.Age.ToString();
            textBox4.Text = _user.Address;
            textBox1.SelectionStart = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mynews myNewsForm = new Mynews(_user);
            myNewsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Allnews myNewsForm = new Allnews();
            myNewsForm.Show();
        }
    }
}
