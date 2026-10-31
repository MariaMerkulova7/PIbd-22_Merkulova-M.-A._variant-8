using ScheduleSystem.Forms;
using Unity;

namespace ScheduleSystem
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void аудиторииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormAudiences>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчики кликов по меню мы добавим позже, 
        // когда создадим формы для справочников и операций.
    }
}
