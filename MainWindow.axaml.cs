using System;
using Avalonia.Controls;
using Avalonia.Data;
using System.Data;
using DBtools;
namespace Academy;

public partial class MainWindow : Window
{ 
    DBtools.Connector connector;
    public MainWindow()
    {
      InitializeComponent();
		  connector = new DBtools.Connector("Server=localhost;Initial Catalog=SPU_411;TrustServerCertificate=True;User Id=sa;Password=Password1;");
    }
    private void TabControl_SelectedIndexChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (tabControl?.SelectedIndex == 2)
        {
            DataTable directions = connector.Select("SELECT * FROM Directions");
            dgvDirections.ItemsSource = directions.AsEnumerable();
            
            statusText.Text = $"Количество направлений обучения: {directions.Rows.Count}";
        }
    } 
}
