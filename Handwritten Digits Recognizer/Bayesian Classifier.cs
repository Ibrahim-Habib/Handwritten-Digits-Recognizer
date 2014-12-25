using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handwritten_Digits_Recognizer
{
    class Bayesian_Classifier:Classifier
    {
        private double[] prior;
        private double[][] Sigma;
        private double[][] Mu;
        private int[] classCount;
        
        public Bayesian_Classifier(byte[][]trainingSetFeaturesVectors, byte[] trainingSetClasses, int num_of_classes):base(trainingSetFeaturesVectors,  trainingSetClasses, num_of_classes)
        {
            //this.trainingSetFeaturesVectors = trainingSetFeaturesVectors;
            //this.trainingSetClasses = trainingSetClasses;
            //this.num_of_classes = num_of_classes;
            //if (trainingSetFeaturesVectors.Length > 0)
            //    num_of_features = trainingSetFeaturesVectors[0].Length;
            classCount = new int[num_of_classes];
            for (int i = 0; i < trainingSetClasses.Length; i++)
                classCount[trainingSetClasses[i]]++;

            #region calculate Priors

            prior = new double[num_of_classes];
            for (int i = 0; i < num_of_classes; i++)
                prior[i] = (double)classCount[i] / trainingSetClasses.Length;

            #endregion

            #region caculate Sigma and Mu
            
            Sigma = new double[num_of_classes][];
            Mu = new double[num_of_classes][];
            for (int i = 0; i < num_of_classes; i++)
            {
                Sigma[i] = new double[num_of_features];
                Mu[i] = new double[num_of_features];
            }

            for (int sample = 0; sample < trainingSetFeaturesVectors.Length; sample++)
            {
                for (int feature = 0; feature < trainingSetFeaturesVectors[sample].Length; feature++)
                {
                    Mu[trainingSetClasses[sample]][feature] += trainingSetFeaturesVectors[sample][feature];
                }
            }

            for (int i = 0; i < num_of_classes; i++)
            {
                for (int j = 0; j < Mu[i].Length; j++)
                    Mu[i][j] = Mu[i][j] / classCount[i];
            }

            for (int sample = 0; sample < trainingSetFeaturesVectors.Length; sample++)
            {
                for (int feature = 0; feature < trainingSetFeaturesVectors[sample].Length; feature++)
                {
                    Sigma[trainingSetClasses[sample]][feature] +=
                        (trainingSetFeaturesVectors[sample][feature] - Mu[trainingSetClasses[sample]][feature]) * (trainingSetFeaturesVectors[sample][feature] - Mu[trainingSetClasses[sample]][feature]);
                }
            }

            for (int i = 0; i < num_of_classes; i++)
            {
                for (int j = 0; j < Mu[i].Length; j++)
                {
                    Sigma[i][j] = Sigma[i][j] / classCount[i];
                    Sigma[i][j] = Math.Sqrt(Sigma[i][j]);
                }
            }


            #endregion

        }

        public override int classify(byte[] sampleFeaturesVector)
        {
            double[] likelihood;
            double evidence = 0;
            double[] postrior;
            
            // calculate likelihood
            likelihood = new double[num_of_classes];
            for (int c = 0; c < num_of_classes; c++)
            {
                likelihood[c] = 1;
                for (int feature = 0; feature < sampleFeaturesVector.Length; feature++)
                {
                    likelihood[c] *= EquationsCalculator.normalProbability(sampleFeaturesVector[feature], Mu[c][feature], Sigma[c][feature]); 
                }
                int x = (int)(likelihood[c] * 100000);
                if(!double.IsNaN(likelihood[c]) && x > 0)
                    evidence += likelihood[c] * prior[c];
            }

            // calculate postrior
            int maxIndex = 0;
            postrior = new double[num_of_classes];
            for (int c = 0; c < num_of_classes; c++)
            {
                int x = (int)(evidence * 100000);
                if(!double.IsNaN(likelihood[c]) && x > 0)
                    postrior[c] = (prior[c] * likelihood[c]) / evidence;
                if (postrior[c] > postrior[maxIndex])
                    maxIndex = c;
            }
            
            //reject if there were more than one class have the maximum postrior
            for (int c = 0; c < num_of_classes; c++)
            {
                if (postrior[c] == postrior[maxIndex] && c != maxIndex)
                {
                    maxIndex = num_of_classes;
                    break;
                }
            }
            
            return maxIndex;
        }
        

    }
}
