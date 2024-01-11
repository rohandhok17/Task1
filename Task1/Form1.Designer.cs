namespace Task1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            addbutton = new Button();
            label1 = new Label();
            textsearch = new TextBox();
            dataGridView1 = new DataGridView();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(346, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(addbutton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textsearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(27, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 449);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.SteelBlue;
            addbutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbutton.Location = new Point(741, 107);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(112, 50);
            addbutton.TabIndex = 3;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 46);
            label1.Name = "label1";
            label1.Size = new Size(253, 54);
            label1.TabIndex = 5;
            label1.Text = "Our Student ";
            // 
            // textsearch
            // 
            textsearch.BorderStyle = BorderStyle.FixedSingle;
            textsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(567, 113);
            textsearch.Name = "textsearch";
            textsearch.PlaceholderText = " Search..";
            textsearch.Size = new Size(150, 39);
            textsearch.TabIndex = 4;
            textsearch.TextChanged += textsearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstname, lastname, gender, age, Class });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 240, 175);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(37, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 240, 175);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(816, 230);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // firstname
            // 
            firstname.HeaderText = "FirstName";
            firstname.MinimumWidth = 8;
            firstname.Name = "firstname";
            // 
            // lastname
            // 
            lastname.HeaderText = "LastName";
            lastname.MinimumWidth = 8;
            lastname.Name = "lastname";
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            // 
            // age
            // 
            age.HeaderText = "Age";
            age.MinimumWidth = 8;
            age.Name = "age";
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.MinimumWidth = 8;
            Class.Name = "Class";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1300, 800);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Our Student";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addbutton;
        private TextBox textsearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn Class;
    }
}
