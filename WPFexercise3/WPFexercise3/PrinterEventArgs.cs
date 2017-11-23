using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFexercise3
{
    public class PrinterEventArgs:EventArgs
    {  
        bool iscritic;
        static protected DateTime date;
        protected string errormessage;
        protected string printerName;

        public PrinterEventArgs(bool Critical, string Description, string PrinterName)
        {
            date = new DateTime();
            iscritic = Critical;
            errormessage = Description;
            printerName = PrinterName;
        }
        public string GetErrorMessage()
        {
            return errormessage;
        }
        public string GetPrinterName()
        {
            return printerName;
        }
    }
}
