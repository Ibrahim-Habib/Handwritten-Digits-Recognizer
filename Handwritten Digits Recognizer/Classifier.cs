using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handwritten_Digits_Recognizer
{
    abstract class Classifier
    {
        protected byte[][] trainingSetFeaturesVectors;
        protected byte[] trainingSetClasses;
        protected int num_of_classes;
        protected int num_of_features;

        public Classifier()
        { 
        
        }

        public Classifier(byte[][] trainingSetFeaturesVectors, byte[] trainingSetClasses, int num_of_classes)
        {
            this.trainingSetFeaturesVectors = trainingSetFeaturesVectors;
            this.trainingSetClasses = trainingSetClasses;
            this.num_of_classes = num_of_classes;
            if (trainingSetFeaturesVectors.Length > 0)
                this.num_of_features = trainingSetFeaturesVectors[0].Length;
        }

        abstract public int classify(byte[] sampleFeatureVector);
        
    }
}
