using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.MvvmCore;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var command = new RelayCommand(DoSth, CanDoSth);
            DataContext = new CommandViewModel(command);
            InitializeComponent();
        }

        private bool CanDoSth(object obj)
        {
            if (cbDisable?.IsChecked != null)
                return !cbDisable.IsChecked.Value;
            else
                return true;
        }

        private void DoSth(object obj)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

    }
}
