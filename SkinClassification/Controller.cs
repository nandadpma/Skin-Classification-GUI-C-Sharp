using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinClassification
{
    public class Controller
    {
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Controller();
                return _instance;
            }
        }

        static Form1 main_form;// = new Form1();
        //static main main_screen;
        //static second second_screen;
        //static third third_screen;
        public Controller()
        {

        }

        public Controller(Form1 form)
        {
            main_form = form;
            init();
        }

        public void load_main_screen()
        {
            if (!main_form.panel2.Controls.Contains(main_menu.Instance))
            {
                main_form.panel2.Controls.Add(main_menu.Instance);
                main_menu.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
                main_menu.Instance.BringToFront();
            }
            else
            {
                main_menu.Instance.BringToFront();
            }
        }

        public static void reload_classification() {
            classification.Instance.Dispose();
            //Form1.ctrler.load_classification_screen();
            //GC.Collect();
            //classification.Instance.
            //Controller.Instance.load_classification_screen();
            //main_form.panel2.Controls.Remove(classification.Instance);
            //main_form.panel2.Controls.Add(classification.Instance);
            //classification.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
            //classification.Instance.BringToFront();
        }

        public void load_classification_screen()
        {
            if (!main_form.panel2.Controls.Contains(classification.Instance))
            {
                main_form.panel2.Controls.Add(classification.Instance);
                classification.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
                classification.Instance.BringToFront();
            }
            else
            {
                classification.Instance.BringToFront();
            }
        }

        public static void update_dgv() {
            classification.Instance.dgvDataLatih.Rows.Clear();
            classification.Instance.dgvDataLatih.Update();
            classification.Instance.dgvDataUji.Rows.Clear();
            classification.Instance.dgvDataUji.Update();

        }

        public void load_configuration_screen()
        {
            if (!main_form.panel2.Controls.Contains(configuration.Instance))
            {
                main_form.panel2.Controls.Add(configuration.Instance);
                configuration.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
                configuration.Instance.BringToFront();
            }
            else
            {
                configuration.Instance.BringToFront();
            }
        }

        public void hideUserManuals() {
            usermanuals.Instance.button1.Visible = false;
            usermanuals.Instance.button1.Visible = false;
            usermanuals.Instance.button2.Visible = false;
            usermanuals.Instance.button3.Visible = false;
        }
        public void load_usermanuals_screen()
        {
            usermanuals.Instance.button1.Visible = true;
            usermanuals.Instance.button1.Visible = true;
            usermanuals.Instance.button2.Visible = true;
            usermanuals.Instance.button3.Visible = true;
            if (!main_form.panel2.Controls.Contains(usermanuals.Instance))
            {
                main_form.panel2.Controls.Add(usermanuals.Instance);
                usermanuals.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
                usermanuals.Instance.BringToFront();
            }
            else
            {
                usermanuals.Instance.BringToFront();
            }
        }

        public void init()
        {
            if (!main_form.panel2.Controls.Contains(main_menu.Instance))
            {
                main_form.panel2.Controls.Add(main_menu.Instance);
                main_menu.Instance.Dock = System.Windows.Forms.DockStyle.Fill;
                main_menu.Instance.BringToFront();
            }
            else
            {
                main_menu.Instance.BringToFront();
            }
        }
    }
}
