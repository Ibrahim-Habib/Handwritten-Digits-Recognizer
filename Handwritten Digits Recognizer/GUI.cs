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
            Klabel.Visible = false;
            KTextBox.Visible = false;

        }

       
        private void classifyButton_Click(object sender, EventArgs e)
        {
            FileReader fr = new FileReader();
            trainingImages = fr.readFeaturesVectors("train-images.idx3-ubyte", 60000);
            trainingLabels = fr.readLables("train-labels.idx1-ubyte", 60000);
            testingImages = fr.readFeaturesVectors("t10k-images.idx3-ubyte", 1);
            testingLabels = fr.readLables("t10k-labels.idx1-ubyte", 1);
                
            if (ClassificationMethodComboBox.Text == "KNN")
            {
                KNN_Classifier classifier = new KNN_Classifier(trainingImages, trainingLabels, 10);
                confusionMatrix = new int[10][];
                for (int i = 0; i < 10; i++)
                    confusionMatrix[i] = new int[11];

                int correctLabel, classifierResult;
                int K = int.Parse(KTextBox.Text);
                for (int i = 0; i < 1; i++)
                {
                    correctLabel = testingLabels[i];
                    classifierResult = classifier.classifySample(K, testingImages[i]);
                    confusionMatrix[correctLabel][classifierResult]++;
                }

                string[] rowsTitles, colTitles;
                rowsTitles = new string[10];
                colTitles = new string[11];
                for (int i = 0; i < 10; i++)
                {
                    rowsTitles[i] = string.Concat("Class ", (i).ToString());
                    colTitles[i] = string.Concat("Class ", (i).ToString()); 
                }
                colTitles[10] = "Rejection";

                for (int i = 0; i <= colTitles.Length; i++)
                {
                    string header = "";
                    if (i > 0)
                        header = colTitles[i - 1];
                    confusionMatrixDataGridView.Columns.Add(new DataGridViewColumn() { HeaderText = header, CellTemplate = new DataGridViewTextBoxCell() });
                }

                for (int i = 0; i < rowsTitles.Length; i++)
                {
                    confusionMatrixDataGridView.Rows.Add(new DataGridViewRow());
                    confusionMatrixDataGridView.Rows[i].Cells[0].Value = rowsTitles[i];
                }

                for (int row = 0; row < rowsTitles.Length; row++)
                {
                    for (int col = 1; col <= colTitles.Length; col++)
                    {
                        confusionMatrixDataGridView[row, col].Value = confusionMatrix[row][col - 1].ToString();
                    }
                }
        
                
               
            }
        }

        private void ClassificationMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassificationMethodComboBox.Text == "KNN")
            {
                Klabel.Visible = true;
                KTextBox.Visible = true;
            }
            else
            {
                Klabel.Visible = false;
                KTextBox.Visible = false;
            
            }
        }

       
        
    }
}
