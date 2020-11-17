using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinClassification
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string trainingResult = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SkinClassification\training\";
            DateTime curDate = DateTime.Now;
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(trainingResult))
                {
                    Directory.CreateDirectory(trainingResult);
                    Console.WriteLine("Directory now is Exist");
                }
            }
            catch (IOException e)
            {
                if (e.Source != null) Console.WriteLine("OOPS, We have a problem {0}", e.Source);
            }

            Form1 main_form = new Form1();
            Controller controller = new Controller(main_form);
            Application.Run(main_form);
        }
    }
}
