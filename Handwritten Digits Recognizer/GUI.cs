using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Handwritten_Digits_Recognizer
{
    public partial class GUI : Form
    {
        public byte[][] trainingImages, testingImages;
        public byte[] trainingLabels, testingLabels;
        public int[][] confusionMatrix;

        public GUI()
        {
            InitializeComponent();
        }

       
        private void classifyButton_Click(object sender, EventArgs e)
        {
            FileReader fr = new FileReader();
           // download the MNIST database files from here http://yann.lecun.com/exdb/mnist/
           // uncompress the downloaded files
           // move the files to the following folder in the project 
            //"Handwritten Digits Recognizer\Handwritten Digits Recognizer\bin\Debug"
            
            //trainingImages = fr.readFeaturesVectors("train-images.idx3-ubyte", 60000);
            //trainingLabels = fr.readLables("train-labels.idx1-ubyte", 60000);
            //testingImages = fr.readFeaturesVectors("t10k-images.idx3-ubyte", 10000);
            //testingLabels = fr.readLables("t10k-labels.idx1-ubyte", 10000);

            trainingImages = fr.readFeaturesVectors("D:\\FCIS\\4th year\\First Term\\Pattern Recognition\\Project\\train-images.idx3-ubyte", 60000);
            trainingLabels = fr.readLables("D:\\FCIS\\4th year\\First Term\\Pattern Recognition\\Project\\train-labels.idx1-ubyte", 60000);
            testingImages = fr.readFeaturesVectors("D:\\FCIS\\4th year\\First Term\\Pattern Recognition\\Project\\t10k-images.idx3-ubyte", 10000);
            testingLabels = fr.readLables("D:\\FCIS\\4th year\\First Term\\Pattern Recognition\\Project\\t10k-labels.idx1-ubyte", 10000);

            Classifier classifier;
            if (ClassificationMethodComboBox.Text == "KNN")
            {
                classifier = new KNN_Classifier(trainingImages, trainingLabels, 10);
            }
            else 
            {
                classifier = new Bayesian_Classifier(trainingImages, trainingLabels, 10);
            }

            confusionMatrix = new int[10][];
                for (int i = 0; i < 10; i++)
                    confusionMatrix[i] = new int[11];

                int correctLabel, classifierResult;
                for (int i = 0; i < 10000; i++)
                {
                    correctLabel = testingLabels[i];
                    classifierResult = classifier.classify(testingImages[i]);
                    confusionMatrix[correctLabel][classifierResult]++;
                }

                //string[] rowsTitles, colTitles;
                //rowsTitles = new string[10];
                //colTitles = new string[11];
                //for (int i = 0; i < 10; i++)
                //{
                //    rowsTitles[i] = string.Concat("Class ", (i).ToString());
                //    colTitles[i] = string.Concat("Class ", (i).ToString()); 
                //}

                //colTitles[10] = "Rejection";

                //confusionMatrixDataGridView.Columns.Add(new DataGridViewColumn() { HeaderText = "", CellTemplate = new DataGridViewTextBoxCell() });
                //for (int i = 0; i < 10; i++)
                //{
                //   string header = string.Concat("Class ", (i).ToString());
                //   confusionMatrixDataGridView.Columns.Add(new DataGridViewColumn() { HeaderText = header, CellTemplate = new DataGridViewTextBoxCell() });
                //}

                //confusionMatrixDataGridView.Columns.Add(new DataGridViewColumn() { HeaderText = "Rejection", CellTemplate = new DataGridViewTextBoxCell() });


                for (int i = 0; i < 10; i++)
                {
                    confusionMatrixDataGridView.Rows.Add(new DataGridViewRow());
                    confusionMatrixDataGridView.Rows[i].Cells[0].Value = string.Concat("Class ", (i).ToString());
                }

                int sum = 0;
                for (int row = 0; row < 10; row++)
                {
                    sum = 0;
                    for (int col = 1; col <= 11; col++)
                    {
                        confusionMatrixDataGridView[col + 1, row].Value = confusionMatrix[row][col - 1].ToString();
                        sum += confusionMatrix[row][col - 1];
                    }
                    confusionMatrixDataGridView[1 , row].Value = sum.ToString();
                    confusionMatrixDataGridView["Accuracy", row].Value = string.Concat((confusionMatrix[row][row] * 100.0 / sum).ToString(), "%");
                }
        
                
               
            }
        

        private void ClassificationMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        
    }
}
