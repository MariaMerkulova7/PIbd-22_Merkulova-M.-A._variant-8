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
    public partial class FormDiscipline : Form
    {
        private readonly IDisciplineRepository _disciplineRepository;
        private int? _disciplineId;

        public int Id
        {
            set
            {
                try
                {
                    var discipline = _disciplineRepository.ReadDisciplineById(value);
                    if (discipline == null)
                    {
                        throw new Exception("Запись не найдена");
                    }

                    textBoxName.Text = discipline.Name;
                    textBoxDescription.Text = discipline.Description;
                    _disciplineId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormDiscipline(IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();
            _disciplineRepository = disciplineRepository ?? throw new ArgumentNullException(nameof(disciplineRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    throw new Exception("Название дисциплины обязательно для заполнения");
                }

                if (_disciplineId.HasValue)
                {
                    _disciplineRepository.UpdateDiscipline(CreateDiscipline(_disciplineId.Value));
                }
                else
                {
                    _disciplineRepository.CreateDiscipline(CreateDiscipline(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Discipline CreateDiscipline(int id) => Discipline.CreateEntity(
            id,
            textBoxName.Text,
            textBoxDescription.Text);
    }
}