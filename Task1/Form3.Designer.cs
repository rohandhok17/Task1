namespace Task1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            age = new Label();
            dob = new Label();
            gender = new Label();
            last = new Label();
            first = new Label();
            label2 = new Label();
            panel1 = new Panel();
            age1 = new Label();
            date1 = new Label();
            gender1 = new Label();
            last1 = new Label();
            first1 = new Label();
            label1 = new Label();
            label3 = new Label();
            label22 = new Label();
            label15 = new Label();
            txt_firstname = new TextBox();
            label16 = new Label();
            label13 = new Label();
            buttoncancel = new Button();
            txt_lastname = new TextBox();
            buttonsave = new Button();
            buttondelete = new Button();
            label21 = new Label();
            textBox2 = new TextBox();
            label17 = new Label();
            label23 = new Label();
            label14 = new Label();
            label12 = new Label();
            txtcombo = new ComboBox();
            txt_age = new TextBox();
            label20 = new Label();
            dateTimePicker2 = new DateTimePicker();
            txt_class = new TextBox();
            label19 = new Label();
            label18 = new Label();
            bindingSource1 = new BindingSource(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(age);
            groupBox1.Controls.Add(dob);
            groupBox1.Controls.Add(gender);
            groupBox1.Controls.Add(last);
            groupBox1.Controls.Add(first);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(318, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 791);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(1211, 402);
            age.Name = "age";
            age.Size = new Size(0, 25);
            age.TabIndex = 79;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Location = new Point(869, 402);
            dob.Name = "dob";
            dob.Size = new Size(0, 25);
            dob.TabIndex = 78;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(401, 333);
            gender.Name = "gender";
            gender.Size = new Size(0, 25);
            gender.TabIndex = 77;
            // 
            // last
            // 
            last.AutoSize = true;
            last.Location = new Point(869, 262);
            last.Name = "last";
            last.Size = new Size(0, 25);
            last.TabIndex = 76;
            // 
            // first
            // 
            first.AutoSize = true;
            first.Location = new Point(869, 181);
            first.Name = "first";
            first.Size = new Size(0, 25);
            first.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point(866, 183);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.Controls.Add(age1);
            panel1.Controls.Add(date1);
            panel1.Controls.Add(gender1);
            panel1.Controls.Add(last1);
            panel1.Controls.Add(first1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txt_firstname);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(buttoncancel);
            panel1.Controls.Add(txt_lastname);
            panel1.Controls.Add(buttonsave);
            panel1.Controls.Add(buttondelete);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtcombo);
            panel1.Controls.Add(txt_age);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(txt_class);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Location = new Point(25, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 732);
            panel1.TabIndex = 81;
            panel1.Paint += panel1_Paint;
            // 
            // age1
            // 
            age1.AutoSize = true;
            age1.Location = new Point(534, 372);
            age1.Name = "age1";
            age1.Size = new Size(21, 25);
            age1.TabIndex = 85;
            age1.Text = "a";
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.Location = new Point(245, 372);
            date1.Name = "date1";
            date1.Size = new Size(23, 25);
            date1.TabIndex = 84;
            date1.Text = "d";
            // 
            // gender1
            // 
            gender1.AutoSize = true;
            gender1.Location = new Point(245, 292);
            gender1.Name = "gender1";
            gender1.Size = new Size(23, 25);
            gender1.TabIndex = 83;
            gender1.Text = "g";
            // 
            // last1
            // 
            last1.AutoSize = true;
            last1.Location = new Point(245, 215);
            last1.Name = "last1";
            last1.Size = new Size(16, 25);
            last1.TabIndex = 82;
            last1.Text = "l";
            // 
            // first1
            // 
            first1.AutoSize = true;
            first1.Location = new Point(245, 135);
            first1.Name = "first1";
            first1.Size = new Size(18, 25);
            first1.TabIndex = 81;
            first1.Text = "f";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 20);
            label1.Name = "label1";
            label1.Size = new Size(243, 54);
            label1.TabIndex = 0;
            label1.Text = "Edit Student";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 346);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 80;
            label3.Text = "years";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11F);
            label22.Location = new Point(80, 100);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(117, 30);
            label22.TabIndex = 62;
            label22.Text = "First Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(192, 98);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 69;
            label15.Text = "*";
            // 
            // txt_firstname
            // 
            txt_firstname.BorderStyle = BorderStyle.FixedSingle;
            txt_firstname.Location = new Point(251, 100);
            txt_firstname.Margin = new Padding(4);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.PlaceholderText = "Please enter  First name";
            txt_firstname.Size = new Size(422, 31);
            txt_firstname.TabIndex = 52;
            txt_firstname.TextChanged += txt_firstname_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(80, 180);
            label16.Name = "label16";
            label16.Size = new Size(108, 30);
            label16.TabIndex = 68;
            label16.Text = "LastName";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(183, 178);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 71;
            label13.Text = "*";
            label13.Click += label13_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.BackColor = SystemColors.ActiveBorder;
            buttoncancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncancel.Location = new Point(570, 654);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(104, 55);
            buttoncancel.TabIndex = 61;
            buttoncancel.Text = "Cancel";
            buttoncancel.UseVisualStyleBackColor = false;
            buttoncancel.Click += buttoncancel_Click;
            // 
            // txt_lastname
            // 
            txt_lastname.BorderStyle = BorderStyle.FixedSingle;
            txt_lastname.Location = new Point(252, 180);
            txt_lastname.Margin = new Padding(4);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.PlaceholderText = "Please enter Last Name";
            txt_lastname.Size = new Size(422, 31);
            txt_lastname.TabIndex = 53;
            txt_lastname.TextChanged += txt_lastname_TextChanged;
            // 
            // buttonsave
            // 
            buttonsave.BackColor = SystemColors.Highlight;
            buttonsave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsave.Location = new Point(459, 654);
            buttonsave.Margin = new Padding(4);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(104, 55);
            buttonsave.TabIndex = 60;
            buttonsave.Text = "Save";
            buttonsave.UseVisualStyleBackColor = false;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = SystemColors.ActiveBorder;
            buttondelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondelete.ForeColor = Color.Red;
            buttondelete.Location = new Point(80, 654);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(104, 55);
            buttondelete.TabIndex = 59;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F);
            label21.Location = new Point(80, 260);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(85, 30);
            label21.TabIndex = 63;
            label21.Text = "Gender";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(251, 500);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Please enter address";
            textBox2.Size = new Size(422, 131);
            textBox2.TabIndex = 58;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F);
            label17.Location = new Point(80, 500);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(91, 30);
            label17.TabIndex = 67;
            label17.Text = "Address";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(512, 338);
            label23.Name = "label23";
            label23.Size = new Size(20, 25);
            label23.TabIndex = 73;
            label23.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(159, 260);
            label14.Name = "label14";
            label14.Size = new Size(20, 25);
            label14.TabIndex = 70;
            label14.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(214, 339);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 72;
            label12.Text = "*";
            // 
            // txtcombo
            // 
            txtcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcombo.FormattingEnabled = true;
            txtcombo.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtcombo.Location = new Point(251, 255);
            txtcombo.Margin = new Padding(4);
            txtcombo.Name = "txtcombo";
            txtcombo.Size = new Size(193, 33);
            txtcombo.TabIndex = 54;
            txtcombo.SelectedIndexChanged += txtcombo_SelectedIndexChanged;
            // 
            // txt_age
            // 
            txt_age.BorderStyle = BorderStyle.FixedSingle;
            txt_age.Location = new Point(541, 337);
            txt_age.Margin = new Padding(4);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(46, 31);
            txt_age.TabIndex = 56;
            txt_age.TextChanged += txt_age_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11F);
            label20.Location = new Point(80, 340);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(135, 30);
            label20.TabIndex = 64;
            label20.Text = "Date of Birth";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(251, 337);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 31);
            dateTimePicker2.TabIndex = 55;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // txt_class
            // 
            txt_class.BorderStyle = BorderStyle.FixedSingle;
            txt_class.Location = new Point(251, 420);
            txt_class.Margin = new Padding(4);
            txt_class.Name = "txt_class";
            txt_class.PlaceholderText = "Please enter class";
            txt_class.Size = new Size(193, 31);
            txt_class.TabIndex = 57;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(463, 340);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(56, 32);
            label19.TabIndex = 65;
            label19.Text = "Age";
            label19.Click += label19_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F);
            label18.Location = new Point(80, 420);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(61, 30);
            label18.TabIndex = 66;
            label18.Text = "Class";
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 931);
            Controls.Add(groupBox1);
            Location = new Point(400, 400);
            Name = "Form3";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Student";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label age;
        private Label dob;
        private Label gender;
        private Label last;
        private Label first;
        private Label label2;
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
        public DateTimePicker dateTimePicker2;
        public ComboBox txtcombo;
        private Label label21;
        private Label label22;
        private Button buttonsave;
        public TextBox txt_lastname;
        public TextBox txt_firstname;
        private BindingSource bindingSource1;
        private Panel panel1;
        private Label label1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label last1;
        private Label first1;
        private Label age1;
        private Label date1;
        private Label gender1;
    }
}