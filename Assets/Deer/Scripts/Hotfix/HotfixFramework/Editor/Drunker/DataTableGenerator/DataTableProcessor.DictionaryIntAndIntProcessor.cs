using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class DictionaryIntAndIntProcessor : GenericDataProcessor<Dictionary<int, int>>
        {
            public override bool IsSystem
            {
                get
                {
                    return false;
                }
            }

            public override string LanguageKeyword
            {
                get
                {
                    return "Dictionary<int, int>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "Dictionary<int, int>",
                };
            }

            public override Dictionary<int, int> Parse(string value)
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                if (value == "-1")
                    return dic;
                string[] dicValue = value.Split(';');
                for (int i = 0; i < dicValue.Length; i++)
                {
                    string[] splitedValue = dicValue[i].Split(',');

                    dic.Add(int.Parse(splitedValue[0]), int.Parse(splitedValue[1]));
                }
                return dic;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                Dictionary<int, int> dic = Parse(value);
                binaryWriter.Write(dic.Count);
                foreach (int key in dic.Keys)
                {
                    binaryWriter.Write(key);
                    binaryWriter.Write(dic[key]);
                }
            }
        }
    }

