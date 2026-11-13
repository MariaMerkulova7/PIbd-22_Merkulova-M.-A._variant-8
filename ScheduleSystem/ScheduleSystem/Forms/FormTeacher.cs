using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleSystem.Entities;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Forms
{
    public partial class FormTeacher : Form
    {
        private readonly ITeacherRepository _teacherRepository;
        private int? _teacherId;

        public int Id
        {
            set
            {
                try
                {
                    var teacher = _teacherRepository.ReadTeacherById(value);
                    if (teacher == null)
                    {
                        throw new Exception("Запись не найдена");
                    }

                    textBoxFirstName.Text = teacher.FirstName;
                    textBoxLastName.Text = teacher.LastName;
                    textBoxMiddleName.Text = teacher.MiddleName;
                    textBoxDepartment.Text = teacher.Department;
                    _teacherId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormTeacher(ITeacherRepository teacherRepository)
        {
            InitializeComponent();
            _teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text))
                {
                    throw new Exception("Имя и Фамилия обязательны для заполнения");
                }

                if (_teacherId.HasValue)
                {
                    _teacherRepository.UpdateTeacher(CreateTeacher(_teacherId.Value));
                }
                else
                {
                    _teacherRepository.CreateTeacher(CreateTeacher(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Teacher CreateTeacher(int id) => Teacher.CreateEntity(
            id,
            textBoxFirstName.Text,
            textBoxLastName.Text,
            textBoxMiddleName.Text,
            textBoxDepartment.Text);
    }
}