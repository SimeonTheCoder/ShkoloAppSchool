namespace ShkoloApp
{
    partial class AddNewStudentForm
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
            addNewStudentFormTitleLabel = new Label();
            button1 = new Button();
            labelStudentName = new Label();
            labelGrade = new Label();
            studentName = new TextBox();
            studentGrade = new TextBox();
            errorInvalidNameLabel = new Label();
            errorInvalidGradeLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // addNewStudentFormTitleLabel
            // 
            addNewStudentFormTitleLabel.Anchor = AnchorStyles.Top;
            addNewStudentFormTitleLabel.AutoSize = true;
            addNewStudentFormTitleLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            addNewStudentFormTitleLabel.Location = new Point(8, 18);
            addNewStudentFormTitleLabel.Name = "addNewStudentFormTitleLabel";
            addNewStudentFormTitleLabel.Size = new Size(291, 65);
            addNewStudentFormTitleLabel.TabIndex = 0;
            addNewStudentFormTitleLabel.Text = "Add Student";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(85, 277);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonClick;
            // 
            // labelStudentName
            // 
            labelStudentName.Anchor = AnchorStyles.Top;
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentName.Location = new Point(55, 114);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(52, 21);
            labelStudentName.TabIndex = 2;
            labelStudentName.Text = "Name";
            // 
            // labelGrade
            // 
            labelGrade.Anchor = AnchorStyles.Top;
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGrade.Location = new Point(55, 192);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(52, 21);
            labelGrade.TabIndex = 3;
            labelGrade.Text = "Grade";
            // 
            // studentName
            // 
            studentName.Anchor = AnchorStyles.Top;
            studentName.Location = new Point(55, 143);
            studentName.Name = "studentName";
            studentName.Size = new Size(193, 23);
            studentName.TabIndex = 4;
            studentName.Validating += ValidateStudentsName;
            // 
            // studentGrade
            // 
            studentGrade.Anchor = AnchorStyles.Top;
            studentGrade.Location = new Point(55, 221);
            studentGrade.Name = "studentGrade";
            studentGrade.Size = new Size(193, 23);
            studentGrade.TabIndex = 5;
            studentGrade.Validating += ValidatingGrade;
            // 
            // errorInvalidNameLabel
            // 
            errorInvalidNameLabel.AutoSize = true;
            errorInvalidNameLabel.BackColor = Color.Transparent;
            errorInvalidNameLabel.ForeColor = Color.Red;
            errorInvalidNameLabel.Location = new Point(57, 168);
            errorInvalidNameLabel.Name = "errorInvalidNameLabel";
            errorInvalidNameLabel.Size = new Size(80, 15);
            errorInvalidNameLabel.TabIndex = 6;
            errorInvalidNameLabel.Text = "Invalid Name!";
            // 
            // errorInvalidGradeLabel
            // 
            errorInvalidGradeLabel.AutoSize = true;
            errorInvalidGradeLabel.BackColor = Color.Transparent;
            errorInvalidGradeLabel.ForeColor = Color.Red;
            errorInvalidGradeLabel.Location = new Point(55, 247);
            errorInvalidGradeLabel.Name = "errorInvalidGradeLabel";
            errorInvalidGradeLabel.Size = new Size(79, 15);
            errorInvalidGradeLabel.TabIndex = 7;
            errorInvalidGradeLabel.Text = "Invalid Grade!";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddNewStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 330);
            Controls.Add(errorInvalidGradeLabel);
            Controls.Add(errorInvalidNameLabel);
            Controls.Add(studentGrade);
            Controls.Add(studentName);
            Controls.Add(labelGrade);
            Controls.Add(labelStudentName);
            Controls.Add(button1);
            Controls.Add(addNewStudentFormTitleLabel);
            Name = "AddNewStudentForm";
            Text = "AddNewStudentForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addNewStudentFormTitleLabel;
        private Button button1;
        private Label labelStudentName;
        private Label labelGrade;
        private TextBox studentName;
        private TextBox studentGrade;
        private Label errorInvalidNameLabel;
        private Label errorInvalidGradeLabel;
        private ErrorProvider errorProvider1;
    }
}