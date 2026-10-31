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
    public partial class FormAudience : Form
    {
        private readonly IAudienceRepository _audienceRepository;
        private int? _audienceId;

        public int Id
        {
            set
            {
                try
                {
                    var audience = _audienceRepository.ReadAudienceById(value);
                    if (audience == null)
                    {
                        throw new InvalidDataException(nameof(audience));
                    }

                    textBoxNumber.Text = audience.Number;
                    numericUpDownCapacity.Value = audience.Capacity;
                    comboBoxType.SelectedItem = audience.AudienceType;
                    _audienceId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public FormAudience(IAudienceRepository audienceRepository)
        {
            InitializeComponent();
            _audienceRepository = audienceRepository ?? throw new ArgumentNullException(nameof(audienceRepository));
            comboBoxType.DataSource = Enum.GetValues(typeof(AudienceType));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNumber.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_audienceId.HasValue)
                {
                    _audienceRepository.UpdateAudience(CreateAudience(_audienceId.Value));
                }
                else
                {
                    _audienceRepository.CreateAudience(CreateAudience(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Audience CreateAudience(int id) => Audience.CreateEntity(
            id,
            textBoxNumber.Text,
            Convert.ToInt32(numericUpDownCapacity.Value),
            (AudienceType)comboBoxType.SelectedItem!);
    }
}