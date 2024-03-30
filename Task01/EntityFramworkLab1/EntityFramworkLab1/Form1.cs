using EntityFramworkLab1.Models;

namespace EntityFramworkLab1
{
    public partial class Form1 : Form
    {
        ItiContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ItiContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_students.DataSource = db.Student.Where(n => n.StFname != "jane").Select(n => new { n.StId, n.StFname, n.StLname, n.StAge, n.StAddress, Department = n.Dept.DeptName, Super = n.StSuperNavigation.StFname }).ToList();
            comboBox1.DataSource = db.Department.ToList();
            comboBox2.DataSource = db.Student.ToList();
            comboBox1.DisplayMember = "DeptName";
            comboBox1.ValueMember = "DeptId";
            comboBox2.DisplayMember = "StFname";
            comboBox2.ValueMember = "StId";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            dgv_students.Columns["StId"].Visible = false;
        }
        int selectedId;
        private void dgv_students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedId = (int)dgv_students.SelectedRows[0].Cells[0].Value;

            Student s = db.Student.Where(n => n.StId == selectedId).FirstOrDefault();
            txt_fname.Text = s.StFname;
            txt_lname.Text = s.StLname;
            txt_address.Text = s.StAddress;
            num_age.Value = (int)s.StAge;
            comboBox1.SelectedValue = s.DeptId ?? 10;
            comboBox2.SelectedValue = s.StSuper??1;

            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_add.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                StFname = txt_fname.Text,
                StLname = txt_lname.Text,
                StAddress = txt_address.Text,
                StAge = (int)num_age.Value,
                DeptId = (int)comboBox1.SelectedValue,
                StSuper = (int)comboBox2.SelectedValue,
            };
            db.Student.Add(s);
            db.SaveChanges();
            txt_fname.Text = txt_lname.Text = txt_address.Text = " ";
            num_age.Value = 0;

            dgv_students.DataSource = db.Student.Where(n => n.StFname != "jane").Select(n => new { n.StId, n.StFname, n.StLname, n.StAge, n.StAddress, Department = n.Dept.DeptName, Super = n.StSuperNavigation.StFname }).ToList();
            MessageBox.Show("added");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Student.Where(n => n.StId == selectedId).FirstOrDefault();
            s.StFname = txt_fname.Text;
            s.StLname = txt_lname.Text;
            s.StAge = (int)num_age.Value;
            s.StAddress = txt_address.Text;
            s.DeptId = (int)comboBox1.SelectedValue;
            s.StSuper = (int)comboBox2.SelectedValue;

            db.SaveChanges();

            txt_fname.Text = txt_lname.Text = txt_address.Text = "";
            num_age.Value = 0;
            dgv_students.DataSource = db.Student.Where(n => n.StFname != "jane").Select(n => new { n.StId, n.StFname, n.StLname, n.StAge, n.StAddress, Department = n.Dept.DeptName, Super = n.StSuperNavigation.StFname }).ToList();

            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_add.Visible = true;
            MessageBox.Show("updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = db.Student.Where(n => n.StId == selectedId).FirstOrDefault();
                db.Student.Remove(s);
                db.SaveChanges();



                txt_fname.Text = txt_lname.Text =txt_address.Text = "";
                num_age.Value = 0;
                dgv_students.DataSource = db.Student.Where(n => n.StFname != "jane").Select(n => new { n.StId, n.StFname, n.StLname, n.StAge, n.StAddress, Department = n.Dept.DeptName, Super = n.StSuperNavigation.StFname }).ToList();

                btn_update.Visible = false;
                btn_delete.Visible = false;
                btn_add.Visible = true;
                MessageBox.Show("deleted");
            }

        }
    }
    
}
