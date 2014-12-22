using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handwritten_Digits_Recognizer
{
    class KNN_Classifier 
    {
        
        private byte[][] trainingSetFeaturesVectors;
        private byte[] trainingSetClasses;
        private double[][] classesMeans;
        private int[] classesCount;
        private int num_of_classes;

        public KNN_Classifier(byte[][]trainingSetFeaturesVectors, byte[]trainingSetClasses, int num_of_classes)
        {
            this.trainingSetFeaturesVectors = trainingSetFeaturesVectors;
            this.trainingSetClasses = trainingSetClasses;
            this.num_of_classes = num_of_classes;
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
