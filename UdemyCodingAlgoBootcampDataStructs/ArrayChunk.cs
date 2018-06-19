using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    class ArrayChunk
    {
        public static int[][] ChunkArray(int[] array, int chunkSize)
        {
            int numberOfSubArrays = array.Length / chunkSize + 1;
            int[][] chunkedArrays = new int[numberOfSubArrays][];

            int indexInputArray = 0;
            int indexOutputArray = 0;

            while(indexInputArray < array.Length)
            {
                int remainingIndexes = array.Length - indexInputArray;

                int chunkSizeConsideringArrayLength = remainingIndexes >= chunkSize ? chunkSize : remainingIndexes;

                int[] chunkedArray = new int[chunkSizeConsideringArrayLength];
                Array.Copy(array, indexInputArray, chunkedArray, 0, chunkSizeConsideringArrayLength);

                chunkedArrays[indexOutputArray] = chunkedArray;
                indexOutputArray++;

                indexInputArray += chunkSizeConsideringArrayLength;
            }

            return chunkedArrays;
        }
    }
}
