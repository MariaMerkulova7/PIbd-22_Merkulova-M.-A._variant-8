namespace ScheduleSystem.Forms
{
    partial class FormCurriculum
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.labelLectureHours = new System.Windows.Forms.Label();
            this.numericUpDownLectureHours = new System.Windows.Forms.NumericUpDown();
            this.labelLabHours = new System.Windows.Forms.Label();
            this.numericUpDownLabHours = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectureHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabHours)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 15);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(50, 15);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "Группа:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 33);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(360, 23);
            this.comboBoxGroup.TabIndex = 1;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(12, 65);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(75, 15);
            this.labelDiscipline.TabIndex = 2;
            this.labelDiscipline.Text = "Дисциплина:";
            // 
            // comboBoxDiscipline
            // 
            this.comboBoxDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscipline.FormattingEnabled = true;
            this.comboBoxDiscipline.Location = new System.Drawing.Point(12, 83);
            this.comboBoxDiscipline.Name = "comboBoxDiscipline";
            this.comboBoxDiscipline.Size = new System.Drawing.Size(360, 23);
            this.comboBoxDiscipline.TabIndex = 3;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(12, 115);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(95, 15);
            this.labelTeacher.TabIndex = 4;
            this.labelTeacher.Text = "Преподаватель:";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(12, 133);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(360, 23);
            this.comboBoxTeacher.TabIndex = 5;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 165);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(40, 15);
            this.labelCourse.TabIndex = 6;
            this.labelCourse.Text = "Курс:";
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(12, 183);
            this.numericUpDownCourse.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownCourse.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(115, 23);
            this.numericUpDownCourse.TabIndex = 7;
            this.numericUpDownCourse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelLectureHours
            // 
            this.labelLectureHours.AutoSize = true;
            this.labelLectureHours.Location = new System.Drawing.Point(135, 165);
            this.labelLectureHours.Name = "labelLectureHours";
            this.labelLectureHours.Size = new System.Drawing.Size(110, 15);
            this.labelLectureHours.TabIndex = 8;
            this.labelLectureHours.Text = "Часы лекций:";
            // 
            // numericUpDownLectureHours
            // 
            this.numericUpDownLectureHours.Location = new System.Drawing.Point(135, 183);
            this.numericUpDownLectureHours.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownLectureHours.Name = "numericUpDownLectureHours";
            this.numericUpDownLectureHours.Size = new System.Drawing.Size(115, 23);
            this.numericUpDownLectureHours.TabIndex = 9;
            // 
            // labelLabHours
            // 
            this.labelLabHours.AutoSize = true;
            this.labelLabHours.Location = new System.Drawing.Point(258, 165);
            this.labelLabHours.Name = "labelLabHours";
            this.labelLabHours.Size = new System.Drawing.Size(115, 15);
            this.labelLabHours.TabIndex = 10;
            this.labelLabHours.Text = "Часы лаб. работ:";
            // 
            // numericUpDownLabHours
            // 
            this.numericUpDownLabHours.Location = new System.Drawing.Point(258, 183);
            this.numericUpDownLabHours.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownLabHours.Name = "numericUpDownLabHours";
            this.numericUpDownLabHours.Size = new System.Drawing.Size(115, 23);
            this.numericUpDownLabHours.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 35);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 35);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormCurriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 270);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownLabHours);
            this.Controls.Add(this.labelLabHours);
            this.Controls.Add(this.numericUpDownLectureHours);
            this.Controls.Add(this.labelLectureHours);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.comboBoxDiscipline);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCurriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учебный план";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectureHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLabHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Label labelLectureHours;
        private System.Windows.Forms.NumericUpDown numericUpDownLectureHours;
        private System.Windows.Forms.Label labelLabHours;
        private System.Windows.Forms.NumericUpDown numericUpDownLabHours;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}