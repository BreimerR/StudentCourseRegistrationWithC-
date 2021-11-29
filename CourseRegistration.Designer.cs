namespace Sarah
{
    partial class CourseRegistration
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
            this.coursesCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.selectDepartmentLabel = new System.Windows.Forms.Label();
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursesCheckBoxList
            // 
            this.coursesCheckBoxList.FormattingEnabled = true;
            this.coursesCheckBoxList.Location = new System.Drawing.Point(12, 88);
            this.coursesCheckBoxList.Name = "coursesCheckBoxList";
            this.coursesCheckBoxList.Size = new System.Drawing.Size(219, 304);
            this.coursesCheckBoxList.TabIndex = 0;
            this.coursesCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.onCourseSelectionChange);
            // 
            // selectDepartmentLabel
            // 
            this.selectDepartmentLabel.AutoSize = true;
            this.selectDepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDepartmentLabel.Location = new System.Drawing.Point(12, 21);
            this.selectDepartmentLabel.Name = "selectDepartmentLabel";
            this.selectDepartmentLabel.Size = new System.Drawing.Size(82, 17);
            this.selectDepartmentLabel.TabIndex = 1;
            this.selectDepartmentLabel.Text = "Department";
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Location = new System.Drawing.Point(12, 51);
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(219, 21);
            this.departmentsComboBox.TabIndex = 2;
            this.departmentsComboBox.SelectedIndexChanged += new System.EventHandler(this.onDepartmentChange);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onSaveClick);
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.departmentsComboBox);
            this.Controls.Add(this.selectDepartmentLabel);
            this.Controls.Add(this.coursesCheckBoxList);
            this.Name = "CourseRegistration";
            this.Text = "CourseRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox coursesCheckBoxList;
        private System.Windows.Forms.Label selectDepartmentLabel;
        private System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.Button button1;
    }
}