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

        // Обработчики кликов по меню мы добавим позже, 
        // когда создадим формы для справочников и операций.
    }
}
