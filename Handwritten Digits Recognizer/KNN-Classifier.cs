using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Handwritten_Digits_Recognizer
{
    class KNN_Classifier:Classifier
    {
        private double[][] classesMeans;
        private int[] classesCount;
        
        public KNN_Classifier(byte[][]trainingSetFeaturesVectors, byte[]trainingSetClasses, int num_of_classes):base(trainingSetFeaturesVectors, trainingSetClasses, num_of_classes)
        {
            this.trainingSetFeaturesVectors = trainingSetFeaturesVectors;
            this.trainingSetClasses = trainingSetClasses;
            this.num_of_classes = num_of_classes;
            if(trainingSetFeaturesVectors.Length > 0)
                this.num_of_features = trainingSetFeaturesVectors[0].Length;

            classesCount = new int[num_of_classes];
            classesMeans = new double[num_of_classes][];
            for (int i = 0; i < num_of_classes; i++)
            {
                classesMeans[i] = new double[num_of_features];
            }

            for (int i = 0; i < trainingSetClasses.Length; i++)
            {
                classesCount[trainingSetClasses[i]]++;
                for (int j = 0; j < trainingSetFeaturesVectors[i].Length; j++)
                {
                    classesMeans[trainingSetClasses[i]][j] += trainingSetFeaturesVectors[i][j];
                }
            }

            for (int i = 0; i < num_of_classes; i++)
            {
                for (int j = 0; j < num_of_features; j++)
                {
                    classesMeans[i][j] /= classesCount[i];
                }
            }

            
        }

        //private int[] PCA(byte[][] dataSet, int num_of_components)
        //{

        //    // reference http://sebastianraschka.com/Articles/2014_pca_step_by_step.html

        //    double[] meanVector = new double[dataSet[0].Length];
        //    #region calculate mean vector
        //    for (int sample = 0; sample < dataSet.Length; sample++)
        //    {
        //        for (int feature = 0; feature < dataSet[sample].Length; feature++)
        //        {
        //            meanVector[feature] += dataSet[sample][feature];
        //        }
        //    }

        //    for (int feature = 0; feature < dataSet[0].Length; feature++)
        //    {
        //        meanVector[feature] /= dataSet.Length;
        //    }

        //    #endregion

        //    #region calculate scatter Matrix
        //    //scatter matrix is alternative to covariance matrix
        //    double[,] xMinusMean, xMinusMeanT;
        //    double[,] scatterMatrix;
        //    xMinusMean = new double[dataSet.Length, num_of_features];
        //    xMinusMeanT = new double[num_of_features, dataSet.Length];
        //    scatterMatrix = new double[num_of_features, num_of_features];

            
        //    for (int sample = 0; sample < dataSet.Length; sample++)
        //    {
        //        for (int feature = 0; feature < dataSet[sample].Length; feature++)
        //        {
        //            xMinusMean[sample,feature] = dataSet[sample][feature] - meanVector[feature];   
        //        }
        //    }

        //    for (int sample = 0; sample < dataSet.Length; sample++)
        //    {
        //        for (int feature = 0; feature < dataSet[sample].Length; feature++)
        //        {
        //            xMinusMeanT[sample , feature] = xMinusMean[feature,sample];
        //        }
        //    }

        //    double sum;
        //    for (int i = 0; i < num_of_features; i++)
        //    {
        //        for (int j = 0; j < num_of_features; j++)
        //        {
        //            sum = 0;
        //            for (int k = 0; k < dataSet.Length; k++)
        //            {
        //                sum += xMinusMean[i, k] * xMinusMeanT[k, j];
        //            }
        //            scatterMatrix[i, j] = sum;
        //        }
        //    }

        //    int[] mostImportantComponents = new int[num_of_components];
        //    Matrix x = new Matrix(scatterMatrix);
        //    Eigen eigen = new Eigen(x);
        //    double maxi = 0;
        //    int maxIndex = 0;
        //    for (int i = 0; i < num_of_features; i++)
        //    {
        //        maxi = 0;
        //        maxIndex = i;
        //        for (int j = i; j < num_of_features; j++)
        //        {
        //            if (eigen.Eigenvalues[j] > maxi)
        //            {
        //                maxIndex = j;
        //                maxi = eigen.Eigenvalues[i].;
        //            }
        //        }
        //    }
            



        //    #endregion

            
        //}

        public override int classify(byte[] sampleFeaturesVector)
        {
            double[] distance = new double[num_of_classes];
            double minDistance = 0;
            int result = 0;
            for (int i = 0; i < classesMeans.Length; i++)
            {
                distance[i] = EquationsCalculator.EculidianDistance(classesMeans[i], sampleFeaturesVector);
                if (i == 0)
                    minDistance = distance[i];
                else
                    minDistance = Math.Min(minDistance, distance[i]);
            }

            int c = 0;
            for (int i = 0; i < distance.Length; i++)
            {
                if (distance[i] == minDistance)
                {
                    result = i;
                    c++;
                }
            }

            if (c > 1)
                result = num_of_classes;


            return result;
        }

        public int classifySample(int K, byte[] sampleFeaturesVector)
        {
            //list are used here because there will be a lot of insertion and deleting operations
            List<double> nearestNeighboursDist = new List<double>();
            List<int> nearestNeighboursClasses = new List<int>();
            int result = 0;


          


            #region find K nearest neighbours
            double distance;
            for (int trainingIndex = 0; trainingIndex < trainingSetClasses.Count(); trainingIndex++)
            {
                  
                distance = EquationsCalculator.EculidianDistance(sampleFeaturesVector, trainingSetFeaturesVectors[trainingIndex]);
                // this is a sequential search O(n)
                // it should be replaced with Binary Search O(log(n)) for optimization
                
                if (nearestNeighboursDist.Count() < K || distance < nearestNeighboursDist[nearestNeighboursDist.Count() - 1])
                {
                    //this loop is used to keep the nearest neighbours sorted 
                    //based on the distance from the sample point
                    if (nearestNeighboursDist.Count() == 0)
                    {
                        nearestNeighboursDist.Insert(0, distance);
                        nearestNeighboursClasses.Insert(0, trainingSetClasses[trainingIndex]);         
                    }
                    else
                    {
                        for (int j = 0; j < nearestNeighboursDist.Count(); j++)
                        {
                            if (distance < nearestNeighboursDist[j])
                            {
                                nearestNeighboursDist.Insert(j, distance);
                                nearestNeighboursClasses.Insert(j, trainingSetClasses[trainingIndex]);
                                break;
                            }
                            else if (j == nearestNeighboursDist.Count() - 1)
                            {
                                nearestNeighboursDist.Add(distance);
                                nearestNeighboursClasses.Add(trainingSetClasses[trainingIndex]);
                                break;
                            }
                        }
                    }

                    if (nearestNeighboursDist.Count() > K)
                    {
                        //removing the farthest point (the point with highest value for distance)
                        nearestNeighboursDist.RemoveAt(nearestNeighboursDist.Count() - 1);
                        nearestNeighboursClasses.RemoveAt(nearestNeighboursClasses.Count() - 1);
                    }
                }

            }
            #endregion
          
            
            #region find the most frequent class in the K-nearest neighbours  
            int[] counters = new int[num_of_classes];
            int maximum_occurence = 0;
            for (int i = 0; i < nearestNeighboursClasses.Count(); i++)
            {
                counters[nearestNeighboursClasses[i]]++;
                maximum_occurence = Math.Max(maximum_occurence, counters[nearestNeighboursClasses[i]]);
            }

            int num_of_maximums = 0;
            for (int i = 0; i < num_of_classes; i++)
            {
                if (counters[i] == maximum_occurence)
                {
                    result = i;
                    num_of_maximums++;
                }
            }

            //reject if there is more than one maximum
            if (num_of_maximums > 1)
                result = num_of_classes;
            
            #endregion

            return result;
        }
    }
}
