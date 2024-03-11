using System.Collections.Generic;
using System.IO;

public class ConvertTool
    {
        public static byte[] ConvertIntArrayToBytes(List<int> matrix)
        {
            if (matrix == null)
            {
                return new byte[0];
            }
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(stream);
                foreach (var item in matrix)
                {
                    bw.Write(item);
                }
                return stream.ToArray();
            }
        }
        //将byte[] 转为 List<int>
        public static List<int> ConvertBytesToIntArray(byte[] matrix)
        {
            if (matrix == null)
                return null;

            List<int> result = new List<int>();
            using (var br = new BinaryReader(new MemoryStream(matrix)))
            {
                var ptCount = matrix.Length / 4;
                for (int i = 0; i < ptCount; i++)
                {
                    result.Add(br.ReadInt32());
                }
                return result;
            }
        }
        public static byte[] ConvertLongArrayToBytes(List<long> matrix)
        {
            if (matrix == null)
            {
                return new byte[0];
            }
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(stream);
                foreach (var item in matrix)
                {
                    bw.Write(item);
                }
                return stream.ToArray();
            }
        }
        //将byte[] 转为 List<long>
        public static List<long> ConvertBytesToLongArray(byte[] matrix)
        {
            if (matrix == null)
                return null;

            List<long> result = new List<long>();
            using (var br = new BinaryReader(new MemoryStream(matrix)))
            {
                var ptCount = matrix.Length / 8;
                for (int i = 0; i < ptCount; i++)
                {
                    result.Add(br.ReadInt64());
                }
                return result;
            }
        }


    }

