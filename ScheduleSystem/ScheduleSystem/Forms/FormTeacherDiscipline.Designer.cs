namespace ScheduleSystem.Forms
{
    partial class FormTeacherDiscipline
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
            this.labelTeacher = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(12, 15);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(95, 15);
            this.labelTeacher.TabIndex = 0;
            this.labelTeacher.Text = "Преподаватель:";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(12, 33);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(360, 23);
            this.comboBoxTeacher.TabIndex = 1;
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(175, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormTeacherDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 170);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxDiscipline);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTeacherDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Связь Преподаватель-Дисциплина";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}