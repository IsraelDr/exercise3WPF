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

namespace WPFexercise3
{
    /// <summary>
    /// Interaction logic for PrinterUserControl.xaml
    /// </summary>
    public partial class PrinterUserControl : UserControl
    {
        public PrinterUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            PrinterUserControl printEnter = sender as PrinterUserControl;
            printEnter.printerNameLabel.FontSize = 25;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            PrinterUserControl printLeave = sender as PrinterUserControl;
            printLeave.printerNameLabel.FontSize = 16;
        }
    }
}
