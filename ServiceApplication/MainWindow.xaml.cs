using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ServiceApplication.MVVM.Models;

namespace ServiceApplication
{
 
    public partial class MainWindow : Window
    {
        public ObservableCollection<DeviceItem> Devices { get; set; } = new ObservableCollection<DeviceItem>()
        {
            new DeviceItem {DeviceId = "1",DeviceType="light", Placement = "Kicken", IsActive = true},
             new DeviceItem {DeviceId = "2",DeviceType="ledstrip" ,Placement = "Livingroom", IsActive = false},
              new DeviceItem {DeviceId = "3",DeviceType="fan", Placement = "Toa", IsActive = false}
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            DeviceList.ItemsSource = Devices;

            //this.WindowState = WindowState.Maximized;
            //this.WindowStartupLocation = WindowStartupLocation.Manual;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }
    }
}
