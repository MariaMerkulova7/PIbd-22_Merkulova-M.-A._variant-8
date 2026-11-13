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
    public partial class FormStudentGroup : Form
    {
        private readonly IStudentGroupRepository _studentGroupRepository;
        private int? _studentGroupId;

        public int Id
        {
            set
            {
                try
                {
                    var group = _studentGroupRepository.ReadStudentGroupById(value);
                    if (group == null)
                    {
                        throw new InvalidDataException(nameof(group));
                    }

                    textBoxGroupName.Text = group.GroupName;
                    numericUpDownCourse.Value = group.Course;
                    numericUpDownStudentCount.Value = group.StudentCount;
                    _studentGroupId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormStudentGroup(IStudentGroupRepository studentGroupRepository)
        {
            InitializeComponent();
            _studentGroupRepository = studentGroupRepository ?? throw new ArgumentNullException(nameof(studentGroupRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxGroupName.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_studentGroupId.HasValue)
                {
                    _studentGroupRepository.UpdateStudentGroup(CreateStudentGroup(_studentGroupId.Value));
                }
                else
                {
                    _studentGroupRepository.CreateStudentGroup(CreateStudentGroup(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private StudentGroup CreateStudentGroup(int id) => StudentGroup.CreateEntity(
            id,
            textBoxGroupName.Text,
            Convert.ToInt32(numericUpDownCourse.Value),
            Convert.ToInt32(numericUpDownStudentCount.Value));
    }
}