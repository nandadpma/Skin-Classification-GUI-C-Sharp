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
    public partial class usermanuals : UserControl
    {
        private static usermanuals _instance;
        public static usermanuals Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usermanuals();
                return _instance;
            }
        }
        public usermanuals()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.DodgerBlue;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DodgerBlue;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.DodgerBlue;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DodgerBlue;
            button2.BackColor = Color.DodgerBlue;
            button3.BackColor = Color.WhiteSmoke;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }
    }
}
