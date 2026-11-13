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
    public partial class FormCurriculum : Form
    {
        private readonly ICurriculumRepository _curriculumRepository;
        private readonly IStudentGroupRepository _studentGroupRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly ITeacherRepository _teacherRepository;

        public FormCurriculum(
            ICurriculumRepository curriculumRepository,
            IStudentGroupRepository studentGroupRepository,
            IDisciplineRepository disciplineRepository,
            ITeacherRepository teacherRepository)
        {
            InitializeComponent();
            _curriculumRepository = curriculumRepository ?? throw new ArgumentNullException(nameof(curriculumRepository));
            _studentGroupRepository = studentGroupRepository ?? throw new ArgumentNullException(nameof(studentGroupRepository));
            _disciplineRepository = disciplineRepository ?? throw new ArgumentNullException(nameof(disciplineRepository));
            _teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));

            // Заполняем ComboBox
            comboBoxGroup.DataSource = _studentGroupRepository.ReadStudentGroups();
            comboBoxGroup.DisplayMember = "GroupName";
            comboBoxGroup.ValueMember = "Id";

            comboBoxDiscipline.DataSource = _disciplineRepository.ReadDisciplines();
            comboBoxDiscipline.DisplayMember = "Name";
            comboBoxDiscipline.ValueMember = "Id";

            comboBoxTeacher.DataSource = _teacherRepository.ReadTeachers();
            comboBoxTeacher.DisplayMember = "LastName";
            comboBoxTeacher.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGroup.SelectedIndex < 0 || comboBoxDiscipline.SelectedIndex < 0 || comboBoxTeacher.SelectedIndex < 0)
                {
                    throw new Exception("Необходимо выбрать группу, дисциплину и преподавателя");
                }

                var curriculum = Curriculum.CreateOperation(
                    0,
                    (int)comboBoxGroup.SelectedValue!,
                    (int)comboBoxDiscipline.SelectedValue!,
                    (int)comboBoxTeacher.SelectedValue!,
                    Convert.ToInt32(numericUpDownCourse.Value),
                    Convert.ToInt32(numericUpDownLectureHours.Value),
                    Convert.ToInt32(numericUpDownLabHours.Value));

                _curriculumRepository.CreateCurriculum(curriculum);
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