using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;


namespace SkinClassification {
    public partial class Form1 : Form {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }
        public static bool show_cls_menu = false;
        public static Controller ctrler = new Controller();
        //public static usermanuals umanuals = new usermanuals();

        public Form1() {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ctrler.load_main_screen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrler.hideUserManuals();
            if (show_cls_menu == false)
            {
                bt_manuals.Location = new Point(0, 280);
                bt_start_classification.Visible = true;
                bt_configuration.Visible = true;
                show_cls_menu = true;
            }
            else {
                bt_manuals.Location = new Point(0, 140);
                bt_start_classification.Visible = false;
                bt_configuration.Visible = false;
                show_cls_menu = false;
            }
            //ctrler.load_second_screen();
        }

        private void bt_start_classification_Click(object sender, EventArgs e)
        {
            ctrler.load_classification_screen();
            bt_start_classification.BackColor = Color.WhiteSmoke;
            bt_configuration.BackColor = Color.Transparent;
            bt_manuals.BackColor = Color.Transparent;
        }

        private void Bt_configuration_Click(object sender, EventArgs e)
        {
            ctrler.load_configuration_screen();
            bt_configuration.BackColor = Color.WhiteSmoke;
            bt_start_classification.BackColor = Color.Transparent;
            bt_manuals.BackColor = Color.Transparent;
        }

        private void Bt_usermanuals_Click(object sender, EventArgs e)
        {
            ctrler.load_usermanuals_screen();
            bt_manuals.BackColor = Color.WhiteSmoke;
            bt_configuration.BackColor = Color.Transparent;
            bt_start_classification.BackColor = Color.Transparent;
        }
    }

    
}
