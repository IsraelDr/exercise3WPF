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
        public MainWindow()
        {
            InitializeComponent();
             public partial class PrintUserControl1 : UserControl
             {
                  public PrintUserControl1()
                  {
                      InitializeComponent();
                      printerCount++;
                      printerName = "Printer" + printerCount.ToString();
                      inkCount =100;
                      PageCount=400;
                  }
                  public void randomPrinting()
                  {
                      inkCount= inkCount- rand.Next(0,100);
                      PageCount= PageCount - rand.Next(0, 400);
                  }
                  EventHandler<PrinterEventArgs> pageMissing, PageesEmpty;
                  protected string printerName;
                  protected decimal inkCount;
                  protected int PageCount;
               static int printerCount=0;
               static int     MAX_Pagees=100;
               static decimal MIN_ADD_INK = 10;
               static decimal MAX_PRINT_INK = 100;

              static int     MAX_PAGES = 400;
              static decimal MIN_ADD_PAGE = 10;
              static decimal MAX_PRINT_PAGES = 100;
              
              static Random rand = new Random();




             }
    }
    
}
