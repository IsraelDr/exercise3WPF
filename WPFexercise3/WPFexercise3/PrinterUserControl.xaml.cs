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
        public event EventHandler<PrinterEventArgs> pageMissing, InkEmpty;
        public readonly string printerName;
        protected int inkCount;
        protected int PageCount;


        static int MAX_INK = 100;
        static int MIN_ADD_INK = 10;
        static int MAX_PRINT_INK = 100;

        static readonly int MAX_PAGES = 400;
        static int  MIN_ADD_PAGES = 10;
        static int MAX_PRINT_PAGES = 100;
        static Random rand = new Random();
        static int printerCount = 0;
        public PrinterUserControl()
        {
            InitializeComponent();
            printerCount++;
            printerName = "Printer " + printerCount;
            inkCount = MAX_INK;
            PageCount = MAX_PAGES;
            printerNameLabel.Content = printerName;
        }
        public void randomPrint()
        {
            PrinterEventArgs temp;
            inkCount = inkCount - rand.Next(0, MAX_INK);
            inkCountProgressBar.Value = inkCount;
            PageCount = PageCount - rand.Next(0, MAX_PAGES);
            pageCountSlider.Value = PageCount;
            if(PageCount <= 0)
            {
                temp = new PrinterEventArgs(true,"There are no pages!", printerName);
                pageMissing.Invoke(this,temp);
            }
            else
            {
                if ((inkCount * 100) < 15 && (inkCount * 100) > 10)
                    temp = new PrinterEventArgs(false,"", printerName);
            }
        }


        public void addPages()
        {
            PageCount = PageCount + rand.Next(MIN_ADD_PAGES, MAX_PRINT_PAGES);
        }
        public void addInk()
        {
            PageCount = PageCount + rand.Next(MIN_ADD_INK, MAX_PRINT_INK);
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
