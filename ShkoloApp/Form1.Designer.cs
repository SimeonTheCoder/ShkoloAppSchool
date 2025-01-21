namespace ShkoloApp
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
            shkoloTitle = new Label();
            studentGradesView = new ListView();
            Students = new ColumnHeader();
            Mathematics = new ColumnHeader();
            Informatics = new ColumnHeader();
            Sport = new ColumnHeader();
            addNewStudentButton = new Button();
            SuspendLayout();
            // 
            // shkoloTitle
            // 
            shkoloTitle.Anchor = AnchorStyles.Top;
            shkoloTitle.AutoSize = true;
            shkoloTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            shkoloTitle.Location = new Point(309, 22);
            shkoloTitle.Name = "shkoloTitle";
            shkoloTitle.Size = new Size(134, 50);
            shkoloTitle.TabIndex = 0;
            shkoloTitle.Text = "Shkolo";
            // 
            // studentGradesView
            // 
            studentGradesView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentGradesView.BackColor = Color.LightCyan;
            studentGradesView.Columns.AddRange(new ColumnHeader[] { Students, Mathematics, Informatics, Sport });
            studentGradesView.Location = new Point(27, 94);
            studentGradesView.Name = "studentGradesView";
            studentGradesView.Size = new Size(745, 332);
            studentGradesView.TabIndex = 1;
            studentGradesView.UseCompatibleStateImageBehavior = false;
            studentGradesView.View = View.Details;
            studentGradesView.Click += ListViewGradesMouseClick;
            // 
            // Students
            // 
            Students.Text = "Students";
            Students.Width = 150;
            // 
            // Mathematics
            // 
            Mathematics.Text = "Mathematics";
            Mathematics.Width = 150;
            // 
            // Informatics
            // 
            Informatics.Text = "Informatics";
            Informatics.Width = 150;
            // 
            // Sport
            // 
            Sport.Text = "Sport";
            Sport.Width = 150;
            // 
            // addNewStudentButton
            // 
            addNewStudentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewStudentButton.BackColor = Color.DarkOliveGreen;
            addNewStudentButton.ForeColor = Color.White;
            addNewStudentButton.Location = new Point(602, 31);
            addNewStudentButton.Name = "addNewStudentButton";
            addNewStudentButton.Size = new Size(170, 41);
            addNewStudentButton.TabIndex = 2;
            addNewStudentButton.Text = "Add New Student";
            addNewStudentButton.UseVisualStyleBackColor = false;
            addNewStudentButton.Click += AddNewStudentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addNewStudentButton);
            Controls.Add(studentGradesView);
            Controls.Add(shkoloTitle);
            Name = "Form1";
            Text = "Form1";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shkoloTitle;
        private ListView studentGradesView;
        private ColumnHeader Students;
        private ColumnHeader Mathematics;
        private ColumnHeader Informatics;
        private ColumnHeader Sport;
        private Button addNewStudentButton;
    }
}
