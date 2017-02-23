using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gokkers
{
    static class Program
    {
        static public Form nextform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            do
            {
                Application.Run(nextform);
            } while (nextform != null && !nextform.IsDisposed);
        }
        public static void SetNextForm(Form nextform1)
        {
            nextform = nextform1;
        }
    }
}
