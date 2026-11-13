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
using ScheduleSystem.Entities.Enums;
using ScheduleSystem.Repositories;

namespace ScheduleSystem.Forms
{
    public partial class FormLesson : Form
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IAudienceRepository _audienceRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly IStudentGroupRepository _studentGroupRepository;

        public FormLesson(
            ILessonRepository lessonRepository,
            IAudienceRepository audienceRepository,
            ITeacherRepository teacherRepository,
            IDisciplineRepository disciplineRepository,
            IStudentGroupRepository studentGroupRepository)
        {
            InitializeComponent();
            _lessonRepository = lessonRepository ?? throw new ArgumentNullException(nameof(lessonRepository));
            _audienceRepository = audienceRepository ?? throw new ArgumentNullException(nameof(audienceRepository));
            _teacherRepository = teacherRepository ?? throw new ArgumentNullException(nameof(teacherRepository));
            _disciplineRepository = disciplineRepository ?? throw new ArgumentNullException(nameof(disciplineRepository));
            _studentGroupRepository = studentGroupRepository ?? throw new ArgumentNullException(nameof(studentGroupRepository));

            // Заполняем ComboBox
            comboBoxAudience.DataSource = _audienceRepository.ReadAudiences();
            comboBoxAudience.DisplayMember = "Number";
            comboBoxAudience.ValueMember = "Id";

            comboBoxTeacher.DataSource = _teacherRepository.ReadTeachers();
            comboBoxTeacher.DisplayMember = "LastName";
            comboBoxTeacher.ValueMember = "Id";

            comboBoxDiscipline.DataSource = _disciplineRepository.ReadDisciplines();
            comboBoxDiscipline.DisplayMember = "Name";
            comboBoxDiscipline.ValueMember = "Id";

            comboBoxGroup.DataSource = _studentGroupRepository.ReadStudentGroups();
            comboBoxGroup.DisplayMember = "GroupName";
            comboBoxGroup.ValueMember = "Id";

            // Заполняем CheckedListBox для флагового перечисления
            foreach (var item in Enum.GetValues(typeof(LessonType)))
            {
                if ((LessonType)item != LessonType.None)
                {
                    checkedListBoxLessonType.Items.Add(item);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAudience.SelectedIndex < 0 || comboBoxTeacher.SelectedIndex < 0 ||
                    comboBoxDiscipline.SelectedIndex < 0 || comboBoxGroup.SelectedIndex < 0 ||
                    checkedListBoxLessonType.CheckedItems.Count == 0)
                {
                    throw new Exception("Необходимо заполнить все поля и выбрать тип занятия");
                }

                LessonType lessonType = LessonType.None;
                foreach (var item in checkedListBoxLessonType.CheckedItems)
                {
                    lessonType |= (LessonType)item;
                }

                var lesson = Lesson.CreateOperation(
                    0,
                    (int)comboBoxAudience.SelectedValue!,
                    (int)comboBoxTeacher.SelectedValue!,
                    (int)comboBoxDiscipline.SelectedValue!,
                    (int)comboBoxGroup.SelectedValue!,
                    dateTimePickerTime.Value.TimeOfDay,
                    lessonType);

                _lessonRepository.CreateLesson(lesson);
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