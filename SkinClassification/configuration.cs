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
    public partial class configuration : UserControl
    {
        private static configuration _instance;
        public static configuration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configuration();
                return _instance;
            }
        }
        //static classification cls = new classification();
        public configuration()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            classification.jarak = Convert.ToInt32(this.numDistance.Value);
            this.clbDir.Items.Add("0");
            this.clbDir.Items.Add("45", CheckState.Checked);
            this.clbDir.Items.Add("90");
            this.clbDir.Items.Add("135", CheckState.Checked);
            this.clbFit.Items.Add("Entropy");
            this.clbFit.Items.Add("Energy");
            this.clbFit.Items.Add("Contrast", CheckState.Checked);
            this.clbFit.Items.Add("Homogeneity", CheckState.Checked);
            this.clbFit.Items.Add("ASM");
            this.clbFit.Items.Add("IDM");
            
        }

        private void btUpdateGLCM_Click(object sender, EventArgs e)
        {
            this.clbDir.Update();
            this.clbFit.Update();

            classification.selectedDir = new string[this.clbDir.CheckedItems.Count];
            classification.selectedFitur = new string[this.clbFit.CheckedItems.Count];

            Console.WriteLine("Configuration Updated");
            int x = 0;
            int y = 0;
            foreach (String i in this.clbDir.CheckedItems)
            {
                classification.selectedDir[x] = i; Console.WriteLine(classification.selectedDir[x].ToString());
                x++;
            }
            foreach (String j in this.clbFit.CheckedItems)
            {
                classification.selectedFitur[y] = j; Console.WriteLine(classification.selectedFitur[y].ToString());
                y++;
            }
            image.selectedDir = classification.selectedDir;
            image.selectedFitur = classification.selectedFitur;
            Console.WriteLine("Jumlah Arah : " + this.clbDir.SelectedItems.Count);
            classification.isTrainingLoaded = false;
            classification.isTestingLoaded = false;
            classification.isLearningDone = false;
            Controller.update_dgv();
            //Controller.reload_classification();
            //classification.Instance.Dispose();
            classification.Instance.Update();
            //classification.Instance
            GC.Collect();
        }

    }
}
