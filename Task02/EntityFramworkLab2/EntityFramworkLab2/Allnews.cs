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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFramworkLab2
{
    public partial class Allnews : Form
    {
        LogContext db;
        public Allnews()
        {
            InitializeComponent();
            db = new LogContext();
        }

        private void Allnews_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.news.Select(n => new { n.ID, n.Title, n.Bref, n.Description, n.Date, n.Time, Catalog = n.Cat.Name, Author = n.Auth.UserName }).ToList();
            dataGridView1.Columns["ID"].Visible = false;
        }
    }
}
