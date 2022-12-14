using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMultiForms
{
    internal static class Program
    {
        static public FormTanuloUpdate formTanuloUpdate  = null;
        static public FormTanuloDelete formTanuloDelete = null;
        static public FormTanuloInsert formTanuloInsert = null;
        static public Form_Nyito form_Nyito = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formTanuloUpdate = new FormTanuloUpdate();
            formTanuloDelete = new FormTanuloDelete();
            formTanuloInsert = new FormTanuloInsert();
            form_Nyito = new Form_Nyito();
            Application.Run(form_Nyito);
        }
    }
}
