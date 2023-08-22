using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kata.AN.Chunker
{

    public interface IChunker
    {
        public List<string> ChunkList(string s, int chunks);
        public string[] Chunk(string s, int chunks);
    }

    public class Chunker: IChunker
    {
        public string[] Chunk(string s, int chunks)
        {
            if (chunks <= 0)
                throw new ArgumentException("0");

            if(chunks > s.Length)
                chunks = s.Length;

            var chunkerLenghts = ChunkerLenght(s, chunks);
            var chunkerArray = new string[chunks];
            int index = 0;
            int i = 0;

            foreach (var piece in chunkerLenghts)
            {
                chunkerArray[i] = s.Substring(index, piece);
                index += piece;
                i++;
            }

            return chunkerArray;
        }

        public List<string> ChunkList(string s, int chunks)
        {
            if (chunks <= 0)
                throw new ArgumentException("0");

            if (chunks > s.Length)
                chunks = s.Length;

            List<string> chunksList = new List<string>();
            var chunkerLenghts = ChunkerLenght(s, chunks);
            int index = 0;

            foreach (var piece in chunkerLenghts)
            {
                chunksList.Add(s.Substring(index, piece));
                index += piece;
            }

            return chunksList;
        }


        private List<int> ChunkerLenght(string input, int chunks)
        {
            List<int> chunker = new List<int>();
            int lenght = input.Length;
            for (int i = chunks; i > 0; i--)
            {
                double result = (double) lenght / i;
                bool isDecimal = result != Math.Floor(result);
                int piece = isDecimal ? (int)Math.Ceiling(result) : (int)Math.Floor(result);
                lenght -= piece;
                chunker.Add(piece);
            }
            return chunker;
        }

    }
}
