namespace ScheduleSystem.Forms
{
    partial class FormStudentGroup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelGroupName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.labelStudentCount = new System.Windows.Forms.Label();
            this.numericUpDownStudentCount = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(12, 15);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(110, 15);
            this.labelGroupName.TabIndex = 0;
            this.labelGroupName.Text = "Название группы:";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(12, 33);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(360, 23);
            this.textBoxGroupName.TabIndex = 1;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 65);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(40, 15);
            this.labelCourse.TabIndex = 2;
            this.labelCourse.Text = "Курс:";
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(12, 83);
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(360, 23);
            this.numericUpDownCourse.TabIndex = 3;
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStudentCount
            // 
            this.labelStudentCount.AutoSize = true;
            this.labelStudentCount.Location = new System.Drawing.Point(12, 115);
            this.labelStudentCount.Name = "labelStudentCount";
            this.labelStudentCount.Size = new System.Drawing.Size(140, 15);
            this.labelStudentCount.TabIndex = 4;
            this.labelStudentCount.Text = "Количество студентов:";
            // 
            // numericUpDownStudentCount
            // 
            this.numericUpDownStudentCount.Location = new System.Drawing.Point(12, 133);
            this.numericUpDownStudentCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownStudentCount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownStudentCount.Name = "numericUpDownStudentCount";
            this.numericUpDownStudentCount.Size = new System.Drawing.Size(360, 23);
            this.numericUpDownStudentCount.TabIndex = 5;
            this.numericUpDownStudentCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 170);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 35);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormStudentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 220);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownStudentCount);
            this.Controls.Add(this.labelStudentCount);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.labelGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Группа студентов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Label labelStudentCount;
        private System.Windows.Forms.NumericUpDown numericUpDownStudentCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}