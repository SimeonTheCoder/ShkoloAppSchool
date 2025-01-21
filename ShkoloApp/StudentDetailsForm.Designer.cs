namespace ShkoloApp
{
    partial class StudentDetailsForm
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
            label1 = new Label();
            studentName = new Label();
            studentGrade = new Label();
            studentAverage = new Label();
            labelTotal = new Label();
            unexcusedLabel = new Label();
            excusedLabel = new Label();
            listView1 = new ListView();
            Subject = new ColumnHeader();
            Marks = new ColumnHeader();
            addNewGradeBox = new GroupBox();
            errorNewMark = new Label();
            subjectComboBox = new ComboBox();
            newMarkBox = new TextBox();
            addMarkButton = new Button();
            label3 = new Label();
            label2 = new Label();
            addAbscenceGradeBox = new GroupBox();
            errorAbscenceLabel = new Label();
            abscenceCountBox = new NumericUpDown();
            typeComboBox = new ComboBox();
            label5 = new Label();
            addAbscenceButton = new Button();
            label4 = new Label();
            labelTooManyAbscences = new Label();
            addNewGradeBox.SuspendLayout();
            addAbscenceGradeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)abscenceCountBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 27);
            label1.Name = "label1";
            label1.Size = new Size(271, 50);
            label1.TabIndex = 0;
            label1.Text = "Student Details";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(33, 110);
            studentName.Name = "studentName";
            studentName.Size = new Size(161, 15);
            studentName.TabIndex = 1;
            studentName.Text = "Student name: Student name";
            // 
            // studentGrade
            // 
            studentGrade.AutoSize = true;
            studentGrade.Location = new Point(33, 136);
            studentGrade.Name = "studentGrade";
            studentGrade.Size = new Size(158, 15);
            studentGrade.TabIndex = 2;
            studentGrade.Text = "Student grade Student grade";
            // 
            // studentAverage
            // 
            studentAverage.AutoSize = true;
            studentAverage.Location = new Point(33, 162);
            studentAverage.Name = "studentAverage";
            studentAverage.Size = new Size(97, 15);
            studentAverage.TabIndex = 3;
            studentAverage.Text = "Average: average";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(33, 269);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total: 0";
            // 
            // unexcusedLabel
            // 
            unexcusedLabel.AutoSize = true;
            unexcusedLabel.Location = new Point(33, 239);
            unexcusedLabel.Name = "unexcusedLabel";
            unexcusedLabel.Size = new Size(77, 15);
            unexcusedLabel.TabIndex = 5;
            unexcusedLabel.Text = "Unexcused: 0";
            // 
            // excusedLabel
            // 
            excusedLabel.AutoSize = true;
            excusedLabel.Location = new Point(33, 212);
            excusedLabel.Name = "excusedLabel";
            excusedLabel.Size = new Size(62, 15);
            excusedLabel.TabIndex = 4;
            excusedLabel.Text = "Excused: 0";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightCyan;
            listView1.Columns.AddRange(new ColumnHeader[] { Subject, Marks });
            listView1.Location = new Point(238, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(334, 115);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Subject
            // 
            Subject.Text = "Subject";
            Subject.Width = 100;
            // 
            // Marks
            // 
            Marks.Text = "Marks";
            Marks.Width = 200;
            // 
            // addNewGradeBox
            // 
            addNewGradeBox.Controls.Add(errorNewMark);
            addNewGradeBox.Controls.Add(subjectComboBox);
            addNewGradeBox.Controls.Add(newMarkBox);
            addNewGradeBox.Controls.Add(addMarkButton);
            addNewGradeBox.Controls.Add(label3);
            addNewGradeBox.Controls.Add(label2);
            addNewGradeBox.Location = new Point(235, 241);
            addNewGradeBox.Name = "addNewGradeBox";
            addNewGradeBox.Size = new Size(336, 104);
            addNewGradeBox.TabIndex = 8;
            addNewGradeBox.TabStop = false;
            addNewGradeBox.Text = "Add new mark";
            // 
            // errorNewMark
            // 
            errorNewMark.AutoSize = true;
            errorNewMark.ForeColor = Color.Red;
            errorNewMark.Location = new Point(19, 82);
            errorNewMark.Name = "errorNewMark";
            errorNewMark.Size = new Size(92, 15);
            errorNewMark.TabIndex = 5;
            errorNewMark.Text = "New mark error!";
            // 
            // subjectComboBox
            // 
            subjectComboBox.FormattingEnabled = true;
            subjectComboBox.Items.AddRange(new object[] { "Mathematics", "Informatics", "Sport" });
            subjectComboBox.Location = new Point(125, 54);
            subjectComboBox.Name = "subjectComboBox";
            subjectComboBox.Size = new Size(97, 23);
            subjectComboBox.TabIndex = 4;
            // 
            // newMarkBox
            // 
            newMarkBox.Location = new Point(19, 55);
            newMarkBox.Name = "newMarkBox";
            newMarkBox.Size = new Size(100, 23);
            newMarkBox.TabIndex = 3;
            // 
            // addMarkButton
            // 
            addMarkButton.Location = new Point(228, 53);
            addMarkButton.Name = "addMarkButton";
            addMarkButton.Size = new Size(90, 25);
            addMarkButton.TabIndex = 2;
            addMarkButton.Text = "Add";
            addMarkButton.UseVisualStyleBackColor = true;
            addMarkButton.Click += ButtonAddNewMarkClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 28);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 1;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 28);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Mark";
            // 
            // addAbscenceGradeBox
            // 
            addAbscenceGradeBox.Controls.Add(errorAbscenceLabel);
            addAbscenceGradeBox.Controls.Add(abscenceCountBox);
            addAbscenceGradeBox.Controls.Add(typeComboBox);
            addAbscenceGradeBox.Controls.Add(label5);
            addAbscenceGradeBox.Controls.Add(addAbscenceButton);
            addAbscenceGradeBox.Controls.Add(label4);
            addAbscenceGradeBox.Location = new Point(235, 351);
            addAbscenceGradeBox.Name = "addAbscenceGradeBox";
            addAbscenceGradeBox.Size = new Size(336, 104);
            addAbscenceGradeBox.TabIndex = 9;
            addAbscenceGradeBox.TabStop = false;
            addAbscenceGradeBox.Text = "Abscences";
            // 
            // errorAbscenceLabel
            // 
            errorAbscenceLabel.AutoSize = true;
            errorAbscenceLabel.ForeColor = Color.Red;
            errorAbscenceLabel.Location = new Point(19, 86);
            errorAbscenceLabel.Name = "errorAbscenceLabel";
            errorAbscenceLabel.Size = new Size(114, 15);
            errorAbscenceLabel.TabIndex = 6;
            errorAbscenceLabel.Text = "New abscence error!";
            // 
            // abscenceCountBox
            // 
            abscenceCountBox.Location = new Point(20, 60);
            abscenceCountBox.Name = "abscenceCountBox";
            abscenceCountBox.Size = new Size(39, 23);
            abscenceCountBox.TabIndex = 10;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "Excused", "Unexcused" });
            typeComboBox.Location = new Point(125, 59);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(97, 23);
            typeComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 33);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 5;
            label5.Text = "Count";
            // 
            // addAbscenceButton
            // 
            addAbscenceButton.Location = new Point(228, 58);
            addAbscenceButton.Name = "addAbscenceButton";
            addAbscenceButton.Size = new Size(90, 25);
            addAbscenceButton.TabIndex = 7;
            addAbscenceButton.Text = "Add";
            addAbscenceButton.UseVisualStyleBackColor = true;
            addAbscenceButton.Click += ButtonAddNewAbscenceClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 33);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Type";
            // 
            // labelTooManyAbscences
            // 
            labelTooManyAbscences.AutoSize = true;
            labelTooManyAbscences.ForeColor = Color.White;
            labelTooManyAbscences.Location = new Point(216, 80);
            labelTooManyAbscences.Name = "labelTooManyAbscences";
            labelTooManyAbscences.Size = new Size(206, 15);
            labelTooManyAbscences.TabIndex = 10;
            labelTooManyAbscences.Text = "This student has too many abscences!";
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 477);
            Controls.Add(labelTooManyAbscences);
            Controls.Add(addAbscenceGradeBox);
            Controls.Add(addNewGradeBox);
            Controls.Add(listView1);
            Controls.Add(labelTotal);
            Controls.Add(unexcusedLabel);
            Controls.Add(excusedLabel);
            Controls.Add(studentAverage);
            Controls.Add(studentGrade);
            Controls.Add(studentName);
            Controls.Add(label1);
            Name = "StudentDetailsForm";
            Text = "StudentDetailsForm";
            Load += OnLoad;
            addNewGradeBox.ResumeLayout(false);
            addNewGradeBox.PerformLayout();
            addAbscenceGradeBox.ResumeLayout(false);
            addAbscenceGradeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)abscenceCountBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label studentName;
        private Label studentGrade;
        private Label studentAverage;
        private Label labelTotal;
        private Label unexcusedLabel;
        private Label excusedLabel;
        private ListView listView1;
        private ColumnHeader Subject;
        private ColumnHeader Marks;
        private GroupBox addNewGradeBox;
        private GroupBox addAbscenceGradeBox;
        private Label label2;
        private Label label3;
        private Button addMarkButton;
        private TextBox newMarkBox;
        private ComboBox subjectComboBox;
        private ComboBox typeComboBox;
        private Label label5;
        private Button addAbscenceButton;
        private Label label4;
        private Label labelTooManyAbscences;
        private NumericUpDown abscenceCountBox;
        private Label errorNewMark;
        private Label errorAbscenceLabel;
    }
}