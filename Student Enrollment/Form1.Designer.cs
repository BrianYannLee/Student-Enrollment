namespace Student_Enrollment
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
            lName = new Label();
            lPhone = new Label();
            lDegree = new Label();
            tbName = new TextBox();
            tbPhone = new TextBox();
            cbDegree = new ComboBox();
            bFirst = new Button();
            bPrevious = new Button();
            bEnroll = new Button();
            bNext = new Button();
            bEnd = new Button();
            gbStudentEnrollment = new GroupBox();
            lDegreeError = new Label();
            lPhoneError = new Label();
            lNameError = new Label();
            lvDisplay = new ListView();
            cName = new ColumnHeader();
            cPhone = new ColumnHeader();
            cDegree = new ColumnHeader();
            checkedListBox1 = new CheckedListBox();
            gbStudentEnrollment.SuspendLayout();
            SuspendLayout();
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(28, 16);
            lName.Name = "lName";
            lName.Size = new Size(39, 15);
            lName.TabIndex = 0;
            lName.Text = "Name";
            // 
            // lPhone
            // 
            lPhone.AutoSize = true;
            lPhone.Location = new Point(28, 53);
            lPhone.Name = "lPhone";
            lPhone.Size = new Size(41, 15);
            lPhone.TabIndex = 1;
            lPhone.Text = "Phone";
            // 
            // lDegree
            // 
            lDegree.AutoSize = true;
            lDegree.Location = new Point(28, 85);
            lDegree.Name = "lDegree";
            lDegree.Size = new Size(44, 15);
            lDegree.TabIndex = 2;
            lDegree.Text = "Degree";
            // 
            // tbName
            // 
            tbName.Location = new Point(89, 13);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(89, 50);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(100, 23);
            tbPhone.TabIndex = 4;
            // 
            // cbDegree
            // 
            cbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDegree.FormattingEnabled = true;
            cbDegree.Location = new Point(89, 85);
            cbDegree.Name = "cbDegree";
            cbDegree.Size = new Size(121, 23);
            cbDegree.TabIndex = 5;
            // 
            // bFirst
            // 
            bFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bFirst.Location = new Point(30, 121);
            bFirst.Name = "bFirst";
            bFirst.Size = new Size(36, 23);
            bFirst.TabIndex = 6;
            bFirst.Text = "<<";
            bFirst.UseVisualStyleBackColor = true;
            bFirst.Click += bFirst_Click;
            // 
            // bPrevious
            // 
            bPrevious.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bPrevious.Location = new Point(72, 121);
            bPrevious.Name = "bPrevious";
            bPrevious.Size = new Size(26, 23);
            bPrevious.TabIndex = 7;
            bPrevious.Text = "<";
            bPrevious.UseVisualStyleBackColor = true;
            bPrevious.Click += bPrevious_Click;
            // 
            // bEnroll
            // 
            bEnroll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bEnroll.Location = new Point(104, 121);
            bEnroll.Name = "bEnroll";
            bEnroll.Size = new Size(75, 23);
            bEnroll.TabIndex = 8;
            bEnroll.Text = "Enroll";
            bEnroll.UseVisualStyleBackColor = true;
            bEnroll.Click += bEnroll_Click;
            // 
            // bNext
            // 
            bNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bNext.Location = new Point(185, 121);
            bNext.Name = "bNext";
            bNext.Size = new Size(34, 23);
            bNext.TabIndex = 9;
            bNext.Text = ">";
            bNext.UseVisualStyleBackColor = true;
            bNext.Click += bNext_Click;
            // 
            // bEnd
            // 
            bEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bEnd.Location = new Point(225, 121);
            bEnd.Name = "bEnd";
            bEnd.Size = new Size(33, 23);
            bEnd.TabIndex = 10;
            bEnd.Text = ">>";
            bEnd.UseVisualStyleBackColor = true;
            bEnd.Click += bEnd_Click;
            // 
            // gbStudentEnrollment
            // 
            gbStudentEnrollment.Controls.Add(lDegreeError);
            gbStudentEnrollment.Controls.Add(lPhoneError);
            gbStudentEnrollment.Controls.Add(lNameError);
            gbStudentEnrollment.Controls.Add(bEnd);
            gbStudentEnrollment.Controls.Add(bNext);
            gbStudentEnrollment.Controls.Add(bEnroll);
            gbStudentEnrollment.Controls.Add(bPrevious);
            gbStudentEnrollment.Controls.Add(bFirst);
            gbStudentEnrollment.Controls.Add(cbDegree);
            gbStudentEnrollment.Controls.Add(tbPhone);
            gbStudentEnrollment.Controls.Add(tbName);
            gbStudentEnrollment.Controls.Add(lDegree);
            gbStudentEnrollment.Controls.Add(lPhone);
            gbStudentEnrollment.Controls.Add(lName);
            gbStudentEnrollment.Location = new Point(14, 45);
            gbStudentEnrollment.Name = "gbStudentEnrollment";
            gbStudentEnrollment.Size = new Size(287, 160);
            gbStudentEnrollment.TabIndex = 11;
            gbStudentEnrollment.TabStop = false;
            gbStudentEnrollment.Text = " ";
            // 
            // lDegreeError
            // 
            lDegreeError.AutoSize = true;
            lDegreeError.ForeColor = Color.Red;
            lDegreeError.Location = new Point(225, 85);
            lDegreeError.Name = "lDegreeError";
            lDegreeError.Size = new Size(12, 15);
            lDegreeError.TabIndex = 15;
            lDegreeError.Text = "*";
            // 
            // lPhoneError
            // 
            lPhoneError.AutoSize = true;
            lPhoneError.ForeColor = Color.Red;
            lPhoneError.Location = new Point(203, 50);
            lPhoneError.Name = "lPhoneError";
            lPhoneError.Size = new Size(12, 15);
            lPhoneError.TabIndex = 14;
            lPhoneError.Text = "*";
            // 
            // lNameError
            // 
            lNameError.AutoSize = true;
            lNameError.ForeColor = Color.Red;
            lNameError.Location = new Point(203, 15);
            lNameError.Name = "lNameError";
            lNameError.Size = new Size(12, 15);
            lNameError.TabIndex = 11;
            lNameError.Text = "*";
            // 
            // lvDisplay
            // 
            lvDisplay.Columns.AddRange(new ColumnHeader[] { cName, cPhone, cDegree });
            lvDisplay.FullRowSelect = true;
            lvDisplay.Location = new Point(365, 48);
            lvDisplay.Name = "lvDisplay";
            lvDisplay.Size = new Size(400, 157);
            lvDisplay.TabIndex = 12;
            lvDisplay.UseCompatibleStateImageBehavior = false;
            lvDisplay.View = View.Details;
            // 
            // cName
            // 
            cName.Text = "Name";
            cName.Width = 100;
            // 
            // cPhone
            // 
            cPhone.Text = "Phone";
            cPhone.Width = 100;
            // 
            // cDegree
            // 
            cDegree.Text = "Degree";
            cDegree.Width = 100;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(536, 307);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(lvDisplay);
            Controls.Add(gbStudentEnrollment);
            Name = "Form1";
            Text = "Form1";
            gbStudentEnrollment.ResumeLayout(false);
            gbStudentEnrollment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lName;
        private Label lPhone;
        private Label lDegree;
        private TextBox tbName;
        private TextBox tbPhone;
        private ComboBox cbDegree;
        private Button bFirst;
        private Button bPrevious;
        private Button bEnroll;
        private Button bNext;
        private Button bEnd;
        private GroupBox gbStudentEnrollment;
        private ListView lvDisplay;
        private ColumnHeader cName;
        private ColumnHeader cPhone;
        private ColumnHeader cDegree;
        private CheckedListBox checkedListBox1;
        private Label lDegreeError;
        private Label lPhoneError;
        private Label lNameError;
    }
}
