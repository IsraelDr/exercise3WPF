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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// /
        /// </summary>
        PrinterUserControl CurrentPrinter;
        Queue<PrinterUserControl> queue;
        public MainWindow()
        {
            InitializeComponent();
            queue = new Queue<PrinterUserControl>();
            foreach (Control item in printersGrid.Children)
            {
                if (item is PrinterUserControl)
                {
                    PrinterUserControl printer = item as PrinterUserControl;
                    printer.pageMissing += PagesMissing;
                    printer.pageMissing += nextPrinter;
                    printer.InkEmpty += InkMissing;
                    printer.InkEmpty += nextPrinter;
                    queue.Enqueue(printer);
                }
            }
            CurrentPrinter = queue.Dequeue();
        }

        private void nextPrinter(object sender, PrinterEventArgs e)
        {
            queue.Enqueue(CurrentPrinter);
            CurrentPrinter = queue.Dequeue();
        }

        private void InkMissing(object sender, PrinterEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PagesMissing(object sender, PrinterEventArgs e)
        {
            CurrentPrinter.pageLabel.Foreground = Brushes.Red;
            MessageBox.Show(e.GetErrorMessage(),e.GetPrinterName(), MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPrinter.randomPrint();
        }
    }
    
}
