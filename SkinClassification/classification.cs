using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Accord.Controls;
using Accord.IO;
using Accord.Math;
using Accord.Statistics.Distributions.Univariate;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using System.Text.RegularExpressions;

namespace SkinClassification
{
    public partial class classification : UserControl
    {
        private static classification _instance;
        public static classification Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new classification();
                return _instance;
            }
        }
        //string svm_model_collection_path = System.IO.Path.GetFullPath("..\\training");
        static string svm_model_collection_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SkinClassification\training\";
        public static String[] selectedDir;
        public static String[] selectedFitur;
        public static int jarak;
        public static bool isTrainingLoaded = false;
        //public static bool isTrainingSuccess = false;
        public static bool isTestingLoaded = false;
        public static bool isLearningDone = false;
        bool isRealTest = false;
        //static Bitmap lightimg = new Bitmap("..\\lightimage.jpg");
        static FileInfo[] TrainingImage;
        static FileInfo[] TestingImage;
        static string[] testingImageFileName;

        static image[] training;
        static image[] testing;

        bool[] trainingClass;
        bool[] testingClass;
        DirectoryInfo trainingDir;
        DirectoryInfo testingDir;
        double[][] fitur4training;
        double[][] fitur4testing;
        String minyak = ".*Minyak.*";
        String kering = ".*Tidak.*";
        SupportVectorMachine<Gaussian> svm;
        String[] predictionResult;
        static string[] alltrainfilename, alltestfilename;
        configuration conf = new configuration();
        public classification()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            webBrowser1.Url = new Uri(svm_model_collection_path);
            
            dgvDataLatih.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDataLatih.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataUji.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDataUji.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataUji.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            selectedDir = new string[conf.clbDir.CheckedItems.Count];
            selectedFitur = new string[conf.clbFit.CheckedItems.Count];
            int x = 0;
            int y = 0;
            foreach (String i in conf.clbDir.CheckedItems)
            {
                selectedDir[x] = i;
                x++;
            }
            foreach (String j in conf.clbFit.CheckedItems)
            {
                selectedFitur[y] = j;
                y++;
            }
            image.selectedDir = selectedDir;
            image.selectedFitur = selectedFitur;
        }

        private void btChooseTrainingDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                dgvDataLatih.Rows.Clear();
                trainingDir = new DirectoryInfo(folderDlg.SelectedPath);
                TrainingImage = trainingDir.GetFiles();
                this.progressBar1.Value = 0;
                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = TrainingImage.Length;
                training = new image[TrainingImage.GetLength(0)];
                trainingClass = new bool[TrainingImage.GetLength(0)];
                for (int i = 0; i < TrainingImage.GetLength(0); i++)
                {
                    if (Regex.Match(TrainingImage[i].Name, minyak).Success)
                    {
                        training[i] = new image(new Bitmap(TrainingImage[i].FullName), "minyak", TrainingImage[i].Name, jarak);
                        trainingClass[i] = true;
                    }
                    else if (Regex.Match(TrainingImage[i].Name, kering).Success)
                    {
                        training[i] = new image(new Bitmap(TrainingImage[i].FullName), "kering", TrainingImage[i].Name, jarak);
                        trainingClass[i] = false;
                    }
                    this.progressBar1.Value += 1;
                    String filename = TrainingImage[i].Name;
                    String kelas = training[i].kelas;
                    dgvDataLatih.Rows.Add(filename, kelas);
                    dgvDataLatih.Update();
                }
                fitur4training = getFitur(training);
                isTrainingLoaded = true;
            }
        }

        private void btChooseDataLatih_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseTrainfile = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = true
            };
            DialogResult trainFile = chooseTrainfile.ShowDialog();
            if (trainFile == DialogResult.OK)
            {
                dgvDataLatih.Rows.Clear();
                alltrainfilename = chooseTrainfile.SafeFileNames;
                String dirName = (Path.GetDirectoryName(chooseTrainfile.FileName));
                training = new image[alltrainfilename.Length];
                trainingClass = new bool[alltrainfilename.Length];
                this.progressBar1.Value = 0;
                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = training.Length;
                for (int i = 0; i < alltrainfilename.Length; i++)
                {
                    if (Regex.Match(alltrainfilename[i], minyak).Success)
                    {
                        this.isRealTest = false;
                        training[i] = new image(new Bitmap((String)(dirName + "\\" + alltrainfilename[i])), "minyak", alltrainfilename[i], jarak);
                        trainingClass[i] = true;
                    }
                    else if (Regex.Match(alltrainfilename[i], kering).Success)
                    {
                        this.isRealTest = false;
                        training[i] = new image(new Bitmap((String)(dirName + "\\" + alltrainfilename[i])), "kering", alltrainfilename[i], jarak);
                        trainingClass[i] = false;
                    }
                    else
                    {
                        this.isRealTest = true;
                        training[i] = new image(new Bitmap((String)(dirName + "\\" + alltrainfilename[i])), null, alltrainfilename[i], jarak);
                        trainingClass[i] = false;
                    }
                    this.progressBar1.Value += 1;
                    dgvDataLatih.Rows.Add(alltrainfilename[i], training[i].kelas);
                    dgvDataLatih.Update();
                }
                fitur4training = getFitur(training);
                isTrainingLoaded = true;
            }
        }

        private void btChooseTestDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                dgvDataUji.Rows.Clear();
                testingDir = new DirectoryInfo(folderDlg.SelectedPath);
                TestingImage = testingDir.GetFiles();
                this.progressBar1.Value = 0;
                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = TestingImage.Length;
                testing = new image[TestingImage.GetLength(0)];
                testingClass = new bool[TestingImage.GetLength(0)];
                alltestfilename = new string[TestingImage.GetLength(0)];
                for (int i = 0; i < TestingImage.GetLength(0); i++)
                {
                    if (Regex.Match(TestingImage[i].Name, minyak).Success)
                    {
                        this.isRealTest = false;
                        testing[i] = new image(new Bitmap(TestingImage[i].FullName), "minyak", TestingImage[i].Name, jarak);
                        testingClass[i] = true;
                    }
                    else if (Regex.Match(TestingImage[i].Name, kering).Success)
                    {
                        this.isRealTest = false;
                        testing[i] = new image(new Bitmap(TestingImage[i].FullName), "kering", TestingImage[i].Name, jarak);
                        testingClass[i] = false;
                    }
                    else
                    {
                        this.isRealTest = true;
                        testing[i] = new image(new Bitmap(TestingImage[i].FullName), null, TestingImage[i].Name, jarak);
                        testingClass[i] = false;
                    }
                    this.progressBar1.Value += 1;
                    alltestfilename[i] = TestingImage[i].Name;
                    if (this.isRealTest == false)
                    {
                        dgvDataUji.Rows.Add(alltestfilename[i], testing[i].kelas);
                    }
                    else if (this.isRealTest == true)
                    {
                        dgvDataUji.Rows.Add(alltestfilename[i]);
                    }
                    dgvDataUji.Update();
                }
                fitur4testing = getFitur(testing);
                isTestingLoaded = true;
            }
        }

        private void btChooseDataTesting_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseTestfile = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "jpg",
                Filter = "jpg files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = true
            };
            DialogResult testfile = chooseTestfile.ShowDialog();
            if (testfile == DialogResult.OK)
            {
                dgvDataUji.Rows.Clear();
                alltestfilename = chooseTestfile.SafeFileNames;
                String dirName = (Path.GetDirectoryName(chooseTestfile.FileName));
                testing = new image[alltestfilename.Length];
                testingClass = new bool[alltestfilename.Length];
                this.progressBar1.Value = 0;
                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = testing.Length;
                for (int i = 0; i < alltestfilename.Length; i++)
                {
                    if (Regex.Match(alltestfilename[i], minyak).Success)
                    {
                        this.isRealTest = false;
                        testing[i] = new image(new Bitmap((String)(dirName + "\\" + alltestfilename[i])), "minyak", alltestfilename[i], jarak);
                        testingClass[i] = true;
                    }
                    else if (Regex.Match(alltestfilename[i], kering).Success)
                    {
                        this.isRealTest = false;
                        testing[i] = new image(new Bitmap((String)(dirName + "\\" + alltestfilename[i])), "kering", alltestfilename[i], jarak);
                        testingClass[i] = false;
                    }
                    else
                    {
                        this.isRealTest = true;
                        testing[i] = new image(new Bitmap((String)(dirName + "\\" + alltestfilename[i])), null, alltestfilename[i], jarak);
                        testingClass[i] = false;
                    }
                    this.progressBar1.Value += 1;
                    if (this.isRealTest == false)
                    {
                        dgvDataUji.Rows.Add(alltestfilename[i], testing[i].kelas);
                    }
                    else if (this.isRealTest == true)
                    {
                        dgvDataUji.Rows.Add(alltestfilename[i]);
                    }
                    dgvDataUji.Update();
                }
                fitur4testing = getFitur(testing);
                isTestingLoaded = true;
            }
        }

        private void btTrainingProses_Click(object sender, EventArgs e)
        {
            if (isTrainingLoaded is true)
            {
                var learn = new SequentialMinimalOptimization<Gaussian>() { UseComplexityHeuristic = true, UseKernelEstimation = true };
                this.svm = learn.Learn(fitur4training, trainingClass);
                //Save_Result("../training", DateTime.Now.ToString("yyyyMMdd#HHmmss"));
                Save_Result(svm_model_collection_path, DateTime.Now.ToString("yyyyMMdd#HHmmss"));
                isLearningDone = true;
                webBrowser1.Refresh();
            }
            else if(isLearningDone is true && isTrainingLoaded is false)
            {
                MessageBox.Show("Training Success");
            }
            else if (isLearningDone is false && isTrainingLoaded is false)
            {
                MessageBox.Show("Data Latih Belum Dimasukkan, Masukkan Data Latih Atau Hasil Training Terlebih Dahulu");

                //Console.WriteLine("Training Data belum Dimasukkan");
            }
        }

        public void Save_Result(string filepath, string filename)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
                this.svm.Save(Path.Combine(filepath, filename));
            }
            else
            {
                this.svm.Save(Path.Combine(filepath, filename));
            }
        }

        public SupportVectorMachine<Gaussian> load(String filename)
        {
            return Accord.IO.Serializer.Load<SupportVectorMachine<Gaussian>>(filename);
        }

        private void printFitur(double[,] fitur)
        {
            for (int i = 0; i < fitur.GetLength(0); i++)
            {
                for (int j = 0; j < fitur.GetLength(1); j++)
                {
                    Console.Write(" " + fitur[i, j]);
                }
                Console.WriteLine("");
            }
        }

        private double[][] getFitur(image[] data)
        {
            double[][] allData = new double[data.GetLength(0)][];
            for (int i = 0; i < allData.Length; i++)
            {
                double[] newData = new double[data[0].fitur.GetLength(0) * data[0].fitur.GetLength(1)];
                for (int j = 0; j < data[0].fitur.GetLength(0); j++)
                {
                    for (int k = 0; k < data[0].fitur.GetLength(1); k++)
                    {
                        newData[(data[0].fitur.GetLength(1) * j) + k] = (data[i].fitur[j, k]);
                    }
                }
                allData[i] = newData;
            }
            return allData;
        }

        private void btTestingProses_Click(object sender, EventArgs e)
        {
            if ((isLearningDone is true) && (isTestingLoaded is true))
            {
                bool[] prediction = this.svm.Decide(fitur4testing);
                this.predictionResult = boolToClass(prediction);
                dgvDataUji.Rows.Clear();
                double benar = 0;
                for (int i = 0; i < prediction.Length; i++)
                {
                    if (prediction[i] == testingClass[i])
                    {
                        benar++;
                    }
                    //String filename = TestingImage[i].Name;
                    String filename = alltestfilename[i];
                    String kelas = testing[i].kelas;
                    if (this.isRealTest == false)
                    {
                        dgvDataUji.Rows.Add(filename, kelas, this.predictionResult[i]);
                    }
                    else if (this.isRealTest == true)
                    {
                        dgvDataUji.Rows.Add(filename, null, this.predictionResult[i]);
                    }
                    dgvDataUji.Update();
                }
                if (this.isRealTest == false)
                {
                    double akurasi = (benar / prediction.Length) * 100;
                    this.lbAkurasi.Text = "Akurasi  : " + Math.Round(akurasi) + "%";
                }
                else if (this.isRealTest == true)
                {
                    double akurasi = (benar / prediction.Length) * 100;
                    this.lbAkurasi.Text = "";
                }
            }
            else if (isLearningDone is false)
            {
                MessageBox.Show("Training Belum Dilakukan, Lakukan Training Atau Muat Hasil Training Terlebih Dahulu");
            }
            else if ((isLearningDone is true) && (isTestingLoaded is false))
            {
                MessageBox.Show("Data Uji Belum Dimuat, Muat Data Uji Terlebih Dahulu!");
            }
        }

        private String[] boolToClass(bool[] boolResult)
        {
            String[] result = new string[boolResult.Length];
            for (int i = 0; i < boolResult.Length; i++)
            {
                if (boolResult[i] == true)
                {
                    result[i] = "minyak";
                }
                else if (boolResult[i] == false)
                {
                    result[i] = "kering";
                }
            }
            return result;
        }

        public Bitmap[] getAllImage(Bitmap[,] allImage, int index)
        {
            Bitmap[] g = new Bitmap[allImage.GetLength(1)];
            for (int i = 0; i < allImage.GetLength(1); i++)
            {
                g[i] = allImage[index, i];
            }
            return g;
        }

        public String[] array2dToArray1d(string[,] arraySource, int x)
        {
            string[] arrayTarget = new string[arraySource.GetLength(1)];
            for (int i = 0; i < arraySource.GetLength(1); i++)
            {
                arrayTarget[i] = arraySource[x, i];
            }
            return arrayTarget;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            //status1.Text = "Masukan Direktori Folder Data Latih";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            //status1.Text = "Masukan Direktori Folder Data Uji";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            //status1.Text = "";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            //status1.Text = "";
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            //status1.Text = "Proses Learning Dengan SVM";
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            //status1.Text = "";
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            //status1.Text = "Proses Testing";
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            //status1.Text = "";
        }

        private void dgvDataLatih_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = this.dgvDataLatih.CurrentCell.RowIndex;
            int columnindex = this.dgvDataLatih.CurrentCell.ColumnIndex;
            //pictureBox1.ImageLocation = this.trainingDir+"\\"+dgvDataLatih.Rows[rowindex].Cells[columnindex].Value.ToString();
            System.Diagnostics.Process.Start(this.trainingDir + "\\" + dgvDataLatih.Rows[rowindex].Cells[columnindex].Value.ToString());
        }

        private void dgvDataUji_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvDataUji.CurrentCell.RowIndex;
            int columnindex = dgvDataUji.CurrentCell.ColumnIndex;
            //pictureBox1.ImageLocation = this.testingDir + "\\" + dgvDataUji.Rows[rowindex].Cells[columnindex].Value.ToString();
            System.Diagnostics.Process.Start(this.testingDir + "\\" + dgvDataUji.Rows[rowindex].Cells[columnindex].Value.ToString());
        }

        private void btMuatHasilTraining_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog
            {
                ///*
                InitialDirectory = svm_model_collection_path,
                //InitialDirectory = @"D:\",
                Title = "Browse Files",
                CheckFileExists = true,
                CheckPathExists = true,
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
                //*/
            };
            DialogResult result = ofd1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine(" File yang diload" + ofd1.FileName);
                this.svm = load(ofd1.FileName);
                isLearningDone = true;
            }
        }
    }

    class myBitmap
    {
        public Bitmap picture;
        public String name;
        public myBitmap(Bitmap picture, String name)
        {
            this.picture = picture;
            this.name = name;
        }
    }
}
