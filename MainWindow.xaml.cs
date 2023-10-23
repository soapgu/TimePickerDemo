using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestMetro
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MyViewModel();
            vm.AMTimePickerDate = new DateTime(1900, 1, 1, 9, 15, 0);
            vm.PMTimePickerDate = new DateTime(1900, 1, 1, 14, 30, 0);
            this.DataContext = vm;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("上午的会议时间为{0},下午的会议时间为{1}", vm.AMTimePickerDate?.ToString("HH:mm"), vm.PMTimePickerDate?.ToString("HH:mm")));
        }
    }
}
