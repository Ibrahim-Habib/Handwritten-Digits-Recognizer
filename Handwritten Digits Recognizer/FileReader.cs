using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Handwritten_Digits_Recognizer
{
    class FileReader
    {
        public FileReader()
        { 
        
        }

        public byte[] readLables(string path, int numOfLables)
        {
            FileStream streamReader = new FileStream(path, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(streamReader);

           
            binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            

            byte[] ret = new byte[numOfLables];
            for (int i = 0; i < numOfLables; i++)
            {
                ret[i] = binaryReader.ReadByte();
            }

            streamReader.Close();
            binaryReader.Close();

            return ret;
        }

        public byte[][] readFeaturesVectors(string path, int numOfImages)
        {
            
            FileStream streamReader = new FileStream(path, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(streamReader);

           
            binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            

            byte[][] ret = new byte[numOfImages][];
            for (int i = 0; i < numOfImages; i++)
            {
                ret[i] = new byte[28 * 28];
            }

            for (int i = 0; i < numOfImages * 28 * 28; i++)
            { 
                ret[(int)i / (28 * 28)][(int)i % (28 * 28)] = binaryReader.ReadByte();
            }

            streamReader.Close();
            binaryReader.Close();

            return ret;
        }

    }
}
