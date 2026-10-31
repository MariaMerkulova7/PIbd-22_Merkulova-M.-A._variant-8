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
    public partial class FormTeacherDiscipline : Form
    {
        private readonly ITeacherDisciplineRepository _teacherDisciplineRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private int? _teacherDisciplineId;

        public int Id
        {
            set
            {
                try
                {
                    var td = _teacherDisciplineRepository.ReadTeacherDisciplineById(value);
                    if (td == null) throw new Exception("Запись не найдена");

                    comboBoxTeacher.SelectedValue = td.TeacherId;
                    comboBoxDiscipline.SelectedValue = td.DisciplineId;
                    _teacherDisciplineId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormTeacherDiscipline(
            ITeacherDisciplineRepository teacherDisciplineRepository,
            ITeacherRepository teacherRepository,
            IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();
            _teacherDisciplineRepository = teacherDisciplineRepository ?? throw new ArgumentNullException(nameof(teacherDisciplineRepository));
            _teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
            _disciplineRepository = disciplineRepository ?? throw new ArgumentNullException(nameof(disciplineRepository));

            // Заполняем ComboBox преподавателями
            comboBoxTeacher.DataSource = _teacherRepository.ReadTeachers();
            comboBoxTeacher.DisplayMember = "LastName"; // Показываем фамилию
            comboBoxTeacher.ValueMember = "Id";

            // Заполняем ComboBox дисциплинами
            comboBoxDiscipline.DataSource = _disciplineRepository.ReadDisciplines();
            comboBoxDiscipline.DisplayMember = "Name"; // Показываем название
            comboBoxDiscipline.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTeacher.SelectedIndex < 0 || comboBoxDiscipline.SelectedIndex < 0)
                {
                    throw new Exception("Необходимо выбрать преподавателя и дисциплину");
                }

                var teacherId = (int)comboBoxTeacher.SelectedValue!;
                var disciplineId = (int)comboBoxDiscipline.SelectedValue!;

                if (_teacherDisciplineId.HasValue)
                {
                    _teacherDisciplineRepository.UpdateTeacherDiscipline(
                        TeacherDiscipline.CreateEntity(_teacherDisciplineId.Value, teacherId, disciplineId));
                }
                else
                {
                    _teacherDisciplineRepository.CreateTeacherDiscipline(
                        TeacherDiscipline.CreateEntity(0, teacherId, disciplineId));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}