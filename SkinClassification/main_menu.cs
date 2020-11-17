using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinClassification
{
    public partial class main_menu : UserControl
    {
        private static main_menu _instance;
        public static main_menu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new main_menu();
                return _instance;
            }
        }
        public main_menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
    }
}
