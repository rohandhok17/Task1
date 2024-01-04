namespace Task1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label23 = new Label();
            buttoncancel = new Button();
            buttondelete = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox2 = new TextBox();
            txt_class = new TextBox();
            label18 = new Label();
            txt_age = new TextBox();
            label19 = new Label();
            label20 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtcombo = new ComboBox();
            label21 = new Label();
            label22 = new Label();
            buttonsave = new Button();
            txt_lastname = new TextBox();
            txt_firstname = new TextBox();
            groupBox2 = new GroupBox();
            Age = new Label();
            Date = new Label();
            Gender = new Label();
            Last = new Label();
            First = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(516, 320);
            label23.Name = "label23";
            label23.Size = new Size(20, 25);
            label23.TabIndex = 73;
            label23.Text = "*";
            // 
            // buttoncancel
            // 
            buttoncancel.BackColor = SystemColors.ActiveBorder;
            buttoncancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttoncancel.Location = new Point(528, 610);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(144, 55);
            buttoncancel.TabIndex = 61;
            buttoncancel.Text = "Cancel";
            buttoncancel.UseVisualStyleBackColor = false;
            buttoncancel.Click += buttoncancel_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = SystemColors.ActiveBorder;
            buttondelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondelete.ForeColor = Color.Red;
            buttondelete.Location = new Point(6, 610);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(144, 55);
            buttondelete.TabIndex = 59;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(148, 322);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 72;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(120, 186);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 71;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(94, 250);
            label14.Name = "label14";
            label14.Size = new Size(20, 25);
            label14.TabIndex = 70;
            label14.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(130, 115);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 69;
            label15.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(6, 180);
            label16.Name = "label16";
            label16.Size = new Size(108, 30);
            label16.TabIndex = 68;
            label16.Text = "LastName";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F);
            label17.Location = new Point(6, 460);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(91, 30);
            label17.TabIndex = 67;
            label17.Text = "Address";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 460);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Please enter address";
            textBox2.Size = new Size(462, 122);
            textBox2.TabIndex = 58;
            // 
            // txt_class
            // 
            txt_class.BorderStyle = BorderStyle.FixedSingle;
            txt_class.Location = new Point(210, 390);
            txt_class.Margin = new Padding(4);
            txt_class.Name = "txt_class";
            txt_class.PlaceholderText = "Please enter class";
            txt_class.Size = new Size(210, 31);
            txt_class.TabIndex = 57;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F);
            label18.Location = new Point(6, 390);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(61, 30);
            label18.TabIndex = 66;
            label18.Text = "Class";
            // 
            // txt_age
            // 
            txt_age.BorderStyle = BorderStyle.FixedSingle;
            txt_age.Location = new Point(543, 318);
            txt_age.Margin = new Padding(4);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(46, 31);
            txt_age.TabIndex = 56;
            txt_age.TextChanged += txt_age_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(463, 320);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(56, 32);
            label19.TabIndex = 65;
            label19.Text = "Age";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.Location = new Point(6, 320);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(135, 30);
            label20.TabIndex = 64;
            label20.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(210, 320);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 31);
            dateTimePicker1.TabIndex = 55;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.Leave += dateTimePicker1_Leave;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // txtcombo
            // 
            txtcombo.FormattingEnabled = true;
            txtcombo.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtcombo.Location = new Point(210, 250);
            txtcombo.Margin = new Padding(4);
            txtcombo.Name = "txtcombo";
            txtcombo.Size = new Size(233, 33);
            txtcombo.TabIndex = 54;
            txtcombo.SelectedIndexChanged += txtcombo_SelectedIndexChanged;
            //txtcombo.Items.Insert(0, " Please Select Gender");
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F);
            label21.Location = new Point(6, 250);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(85, 30);
            label21.TabIndex = 63;
            label21.Text = "Gender";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.Location = new Point(6, 110);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(117, 30);
            label22.TabIndex = 62;
            label22.Text = "First Name";
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonsave.Location = new Point(375, 610);
            buttonsave.Margin = new Padding(4);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(144, 55);
            buttonsave.TabIndex = 60;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // txt_lastname
            // 
            txt_lastname.BorderStyle = BorderStyle.FixedSingle;
            txt_lastname.Location = new Point(210, 180);
            txt_lastname.Margin = new Padding(4);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.PlaceholderText = "Please enter Last Name";
            txt_lastname.Size = new Size(462, 31);
            txt_lastname.TabIndex = 53;
            txt_lastname.TextChanged += txt_lastname_TextChanged;
            // 
            // txt_firstname
            // 
            txt_firstname.BorderStyle = BorderStyle.FixedSingle;
            txt_firstname.Location = new Point(210, 110);
            txt_firstname.Margin = new Padding(4);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.PlaceholderText = "Please enter  First name";
            txt_firstname.Size = new Size(462, 31);
            txt_firstname.TabIndex = 52;
            txt_firstname.TextChanged += txt_firstname_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Age);
            groupBox2.Controls.Add(Date);
            groupBox2.Controls.Add(Gender);
            groupBox2.Controls.Add(Last);
            groupBox2.Controls.Add(First);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_firstname);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(buttoncancel);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txt_lastname);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(buttondelete);
            groupBox2.Controls.Add(buttonsave);
            groupBox2.Controls.Add(txtcombo);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(txt_class);
            groupBox2.Controls.Add(txt_age);
            groupBox2.Location = new Point(16, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(768, 767);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(543, 353);
            Age.Name = "Age";
            Age.Size = new Size(21, 25);
            Age.TabIndex = 86;
            Age.Text = "a";
            Age.Click += label2_Click;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(211, 353);
            Date.Name = "Date";
            Date.Size = new Size(23, 25);
            Date.TabIndex = 85;
            Date.Text = "d";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(214, 287);
            Gender.Name = "Gender";
            Gender.Size = new Size(23, 25);
            Gender.TabIndex = 84;
            Gender.Text = "g";
            // 
            // Last
            // 
            Last.AutoSize = true;
            Last.Location = new Point(211, 214);
            Last.Name = "Last";
            Last.Size = new Size(16, 25);
            Last.TabIndex = 83;
            Last.Text = "l";
            // 
            // First
            // 
            First.AutoSize = true;
            First.Location = new Point(210, 145);
            First.Name = "First";
            First.Size = new Size(18, 25);
            First.TabIndex = 82;
            First.Text = "f";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 327);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 81;
            label3.Text = "years";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 17);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
            label1.TabIndex = 74;
            label1.Text = "Add Student";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(314, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 800);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 944);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student ";
            Load += Form2_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label23;
        private Button buttoncancel;
        private Button buttondelete;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        public TextBox textBox2;
        public TextBox txt_class;
        private Label label18;
        public TextBox txt_age;
        private Label label19;
        private Label label20;
        public DateTimePicker dateTimePicker1;
        public ComboBox txtcombo;
        private Label label21;
        private Label label22;
        private Button buttonsave;
        public TextBox txt_lastname;
        public TextBox txt_firstname;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private Label Age;
        private Label Date;
        private Label Gender;
        private Label Last;
        private Label First;
        private Panel panel1;
    }
}