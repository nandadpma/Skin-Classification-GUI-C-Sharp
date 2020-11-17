using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SkinClassification
{
    public class image
    {
        public static String[] selectedDir;
        public static String[] selectedFitur;
        //Bitmap lightimg = new Bitmap("..\\lightimage.jpg");
        public String kelas;
        public String filename;
        int width;
        int height;
        int[,] table;
        int jarak;
        double[,,] glcmMatrix;// = new double[1, 256, 256];
        public double[,] fitur;// = new double[1, 5];

        public image(Bitmap g, String kelas, String filename, int jarak)
        {
            //this.g = g;
            this.kelas = kelas;
            this.filename = filename;
            this.jarak = jarak;
            preprocessing(g);
            glcmMatriks();
        }

        public void preprocessing(Bitmap g)
        {
            try{
                width = g.Width;
                height = g.Height;
                table = new int[height, width];
                for (int x = 0; x < height; x++){
                    for (int y = 0; y < width; y++){
                        Color c = g.GetPixel(y, x);
                        int red = c.R;
                        int green = c.G;
                        int blue = c.B;
                        int p = (red + green + blue) / 3;
                        table[x, y] = p;
                    }
                }
            }
            catch (Exception e) { }
        }

        public void glcmMatriks()
        {
            glcmMatrix = new double[selectedDir.Length, 256, 256];
            fitur = new double[selectedDir.Length, selectedFitur.Length];
            for (int h = 0; h < selectedDir.Length; h++)
            {
                if (selectedDir[h] == "0")
                {
                    for (int i = 0; i < this.table.GetLength(0); i++)
                    {
                        for (int j = 0; j < this.table.GetLength(1) - 1; j++)
                        {
                            int k = this.table[i, j];
                            int l = this.table[i, j + this.jarak];
                            glcmMatrix[h, k, l]++;
                        }
                    }
                }
                else if (selectedDir[h] == "45")
                {
                    for (int i = 1; i < this.table.GetLength(0); i++)
                    {
                        for (int j = 0; j < this.table.GetLength(1) - 1; j++)
                        {
                            int k = this.table[i, j];
                            int l = this.table[i - 1, j + this.jarak];
                            glcmMatrix[h, k, l]++;
                        }
                    }
                }
                else if (selectedDir[h] == "90")
                {
                    for (int i = 1; i < this.table.GetLength(0); i++)
                    {
                        for (int j = 0; j < this.table.GetLength(1); j++)
                        {
                            int k = this.table[i, j];
                            int l = this.table[i - 1, j];
                            glcmMatrix[h, k, l]++;
                        }
                    }
                }
                else if (selectedDir[h] == "135")
                {
                    for (int i = 1; i < this.table.GetLength(0); i++)
                    {
                        for (int j = 1; j < this.table.GetLength(1); j++)
                        {
                            int k = this.table[i, j];
                            int l = this.table[i - 1, j - this.jarak];
                            glcmMatrix[h, k, l]++;
                        }
                    }
                }
            }
            for (int i = 0; i < selectedDir.Length; i++) {
                Console.WriteLine("Hitung Arah : "+selectedDir[i]);
                for (int j = 0; j < selectedFitur.Length; j++) {
                    if (selectedFitur[j] == "Energy") {
                        fitur[i, j] = getEnergy(getArray2D(glcmMatrix, i)); Console.WriteLine("Hitung Fitur : " + selectedFitur[j]);
                    }
                    else if (selectedFitur[j] == "Entropy")
                    {
                        fitur[i, j] = getEntropy(getArray2D(glcmMatrix, i)); Console.WriteLine("Hitung Fitur : " + selectedFitur[j]);
                    }
                    else if (selectedFitur[j] == "Contrast")
                    {
                        fitur[i, j] = getContrast(getArray2D(glcmMatrix, i)); Console.WriteLine("Hitung Fitur : " + selectedFitur[j]);
                    }
                    else if (selectedFitur[j] == "Homogeneity")
                    {
                        fitur[i, j] = getHomogeneity(getArray2D(glcmMatrix, i)); Console.WriteLine("Hitung Fitur : " + selectedFitur[j]);
                    }
                    else if (selectedFitur[j] == "IDM")
                    {
                        fitur[i, j] = getIDM(getArray2D(glcmMatrix, i)); Console.WriteLine("Hitung Fitur : " + selectedFitur[j]);
                    }
                }
            }
            glcmMatrix = null;
            glcmMatrix = new double[1,1,1];
        }

        public double[,] getArray2D(double[,,] glcmMatrix, int index)
        {
            double[,] array = new double[glcmMatrix.GetLength(1), glcmMatrix.GetLength(2)];
            for (int i = 0; i < glcmMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(2); j++)
                {
                    array[i, j] = glcmMatrix[index, i, j];
                }
            }
            return array;
        }

        public double getEnergy(double[,] glcmMatrix)
        {
            double energy = 0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    energy += Math.Pow(glcmMatrix[i, j], 2);
                }
            }
            return energy;
        }

        public double getEntropy(double[,] glcmMatrix)
        {
            double entropy = 0.0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    if (glcmMatrix[i, j] != 0)
                    {
                        entropy = entropy - (glcmMatrix[i, j] * (Math.Log(glcmMatrix[i, j])));
                    }
                }
            }
            return entropy;
        }

        public double getContrast(double[,] glcmMatrix)
        {
            double contrast = 0.0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    contrast += Math.Pow(i - j, 2) * (glcmMatrix[i, j]);
                }
            }
            return contrast;
        }

        public double getHomogeneity(double[,] glcmMatrix)
        {
            double homogeneity = 0.0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    homogeneity += glcmMatrix[i, j] / (1.0 + Math.Abs(i - j));
                }
            }
            return homogeneity;
        }

        public double getAngular2ndMoment(double[,] glcmMatrix)
        {
            double asm = 0.0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    asm += (glcmMatrix[i, j] * glcmMatrix[i, j]);
                }
            }
            return asm;
        }

        public double getIDM(double[,] glcmMatrix)
        {
            double IDM = 0.0;
            for (int i = 0; i < glcmMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < glcmMatrix.GetLength(1); j++)
                {
                    IDM += ((1 / (1 + (Math.Pow(i - j, 2)))) * glcmMatrix[i, j]);
                }
            }
            return IDM;
        }
    }
}