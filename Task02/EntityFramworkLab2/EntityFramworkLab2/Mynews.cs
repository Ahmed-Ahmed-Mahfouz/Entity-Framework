using EntityFramworkLab2.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EntityFramworkLab2
{
    public partial class Mynews : Form
    {
        LogContext db;
        Author theuser;
        public Mynews(Author user)
        {
            InitializeComponent();
            theuser = user;
            db = new LogContext();
        }

        private void Mynews_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.news.Where(n => n.AuthorId == theuser.ID).Select(n => new { n.ID, n.Title, n.Bref, n.Description, n.Date, n.Time, Catalog = n.Cat.Name, Author = n.Auth.UserName }).ToList();
            comboBox1.DataSource = db.Catalogs.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
        }

        int selectedId;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            News n = db.news.Where(n => n.ID == selectedId).FirstOrDefault();
            textBox1.Text = n.Title;
            textBox2.Text = n.Bref;
            textBox3.Text = n.Description;
            comboBox1.SelectedValue = n.CatId;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_add.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            News n = new News()
            {
                Title = textBox1.Text,
                Bref = textBox2.Text,
                Description = textBox3.Text,
                CatId = (int)comboBox1.SelectedValue,
                AuthorId = theuser.ID,
                Date = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                Time = new TimeOnly(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds)
            };
            db.news.Add(n);
            db.SaveChanges();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            dataGridView1.DataSource = db.news.Where(n => n.AuthorId == theuser.ID).Select(n => new { n.ID, n.Title, n.Bref, n.Description, n.Date, n.Time, Catalog = n.Cat.Name, Author = n.Auth.UserName }).ToList();
            MessageBox.Show("added");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            News n = db.news.Where(n => n.ID == selectedId).FirstOrDefault();
            n.Title = textBox1.Text;
            n.Bref = textBox2.Text;
            n.Description = textBox3.Text;
            n.CatId = (int)comboBox1.SelectedValue;
            n.AuthorId = theuser.ID;
            n.Date = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day);
            n.Time = new TimeOnly(DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes, DateTime.Now.TimeOfDay.Seconds);

            db.SaveChanges();

            textBox1.Text = textBox2.Text = textBox3.Text = "";
            dataGridView1.DataSource = db.news.Where(n => n.AuthorId == theuser.ID).Select(n => new { n.ID, n.Title, n.Bref, n.Description, n.Date, n.Time, Catalog = n.Cat.Name, Author = n.Auth.UserName }).ToList();

            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_add.Visible = true;
            MessageBox.Show("updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                News n = db.news.Where(n => n.ID == selectedId).FirstOrDefault();
                db.news.Remove(n);
                db.SaveChanges();

                textBox1.Text = textBox2.Text = textBox3.Text = "";
                dataGridView1.DataSource = db.news.Where(n => n.AuthorId == theuser.ID).Select(n => new { n.ID, n.Title, n.Bref, n.Description, n.Date, n.Time, Catalog = n.Cat.Name, Author = n.Auth.UserName }).ToList();

                btn_update.Visible = false;
                btn_delete.Visible = false;
                btn_add.Visible = true;
                MessageBox.Show("deleted");
            }
        }
    }
}
