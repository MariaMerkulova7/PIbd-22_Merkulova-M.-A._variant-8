using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleSystem.Repositories;
using Unity;

namespace ScheduleSystem.Forms
{
    public partial class FormLessons : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILessonRepository _lessonRepository;

        public FormLessons(IUnityContainer container, ILessonRepository lessonRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _lessonRepository = lessonRepository ?? throw new ArgumentNullException(nameof(lessonRepository));
        }

        private void FormLessons_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLesson>().ShowDialog();
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _lessonRepository.ReadLessons();
    }
}