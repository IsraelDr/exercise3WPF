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
        public MainWindow()
        {
             InitializeComponent();//u see it??
             InitializeComponent();//yfyj
            
            printerName1.printerNameLabel.Content = "printer 1";
            printerName2.printerNameLabel.Content = "printer 2";
            printerName3.printerNameLabel.Content = "printer 3";

        }
            
           
        
        
    }
    
}
