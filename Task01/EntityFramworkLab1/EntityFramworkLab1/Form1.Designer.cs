namespace EntityFramworkLab1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgv_students = new DataGridView();
            txt_address = new TextBox();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            num_age = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(43, 23);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(43, 71);
            label2.Name = "label2";
            label2.Size = new Size(165, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(43, 126);
            label3.Name = "label3";
            label3.Size = new Size(131, 41);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(417, 23);
            label4.Name = "label4";
            label4.Size = new Size(74, 41);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(417, 71);
            label5.Name = "label5";
            label5.Size = new Size(189, 41);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(417, 126);
            label6.Name = "label6";
            label6.Size = new Size(169, 41);
            label6.TabIndex = 5;
            label6.Text = "Supervisor";
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(1, 267);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 51;
            dgv_students.Size = new Size(800, 184);
            dgv_students.TabIndex = 6;
            dgv_students.RowHeaderMouseDoubleClick += dgv_students_RowHeaderMouseDoubleClick;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(220, 140);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(164, 27);
            txt_address.TabIndex = 7;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(220, 37);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(164, 27);
            txt_fname.TabIndex = 8;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(220, 85);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(164, 27);
            txt_lname.TabIndex = 9;
            // 
            // num_age
            // 
            num_age.Location = new Point(616, 38);
            num_age.Name = "num_age";
            num_age.Size = new Size(151, 27);
            num_age.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(616, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(616, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 12;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.DarkSlateGray;
            btn_add.Location = new Point(43, 189);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(171, 61);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.DarkSlateGray;
            btn_update.Location = new Point(330, 193);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(171, 61);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.DarkSlateGray;
            btn_delete.Location = new Point(596, 193);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(171, 61);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(num_age);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(txt_address);
            Controls.Add(dgv_students);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgv_students;
        private TextBox txt_address;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private NumericUpDown num_age;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
