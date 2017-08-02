using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300872344_ASS_2
{
    class Program
    {

        public class Variables
        {
            public decimal Bill = 0M;
        }

        public static Variables variables = new Variables();
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculate_Bill());
        }
    }
}
