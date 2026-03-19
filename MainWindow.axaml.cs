using Avalonia.Controls;
using DBtools;
using Academy.ViewModels;

namespace Academy
{
    public partial class MainWindow : Window
    {
        readonly MainWindowViewModel _viewModel;
        public MainWindow()
        { 
            InitializeComponent();
            Connector connector = new DBtools.Connector("Server=localhost;Initial Catalog=SPU_411;TrustServerCertificate=True;User Id=sa;Password=Password1;");
            _viewModel = new MainWindowViewModel(connector);
            DataContext = _viewModel;
            tabControl.SelectionChanged += TabControl_SelectionChanged;
            _viewModel.LoadTable(0);
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.LoadTable(tabControl.SelectedIndex);
        }
    }
}
