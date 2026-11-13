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
    public partial class FormCurriculums : Form
    {
        private readonly IUnityContainer _container;
        private readonly ICurriculumRepository _curriculumRepository;

        public FormCurriculums(IUnityContainer container, ICurriculumRepository curriculumRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _curriculumRepository = curriculumRepository ?? throw new ArgumentNullException(nameof(curriculumRepository));
        }

        private void FormCurriculums_Load(object sender, EventArgs e)
        {
            try { LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormCurriculum>().ShowDialog();
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _curriculumRepository.DeleteCurriculum(findId);
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _curriculumRepository.ReadCurriculums();

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}