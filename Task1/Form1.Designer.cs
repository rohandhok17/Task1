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
            groupBox1 = new GroupBox();
            label1 = new Label();
            addbutton = new Button();
            textsearch = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addbutton);
            groupBox1.Controls.Add(textsearch);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(340, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 652);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 106);
            label1.Name = "label1";
            label1.Size = new Size(253, 54);
            label1.TabIndex = 5;
            label1.Text = "Our Student ";
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.SteelBlue;
            addbutton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbutton.Location = new Point(765, 263);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(112, 50);
            addbutton.TabIndex = 3;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(577, 268);
            textsearch.Name = "textsearch";
            textsearch.PlaceholderText = " Search..";
            textsearch.Size = new Size(150, 39);
            textsearch.TabIndex = 4;
            textsearch.TextChanged += textsearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(24, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstname, lastname, gender, age, Class });
            dataGridView1.Location = new Point(37, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
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
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addbutton;
        private TextBox textsearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn Class;
        private Label label1;
        private Panel panel1;
    }
}
