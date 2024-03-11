using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class DictionaryStringAndIntProcessor : GenericDataProcessor<Dictionary<string, int>>
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
                    return "Dictionary<string, int>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "Dictionary<string, int>",
                };
            }

            public override Dictionary<string, int> Parse(string value)
            {
                Dictionary<string, int> dic = new Dictionary<string, int>();
                if (value == "-1")
                    return dic;
                string[] dicValue = value.Split(';');
                for (int i = 0; i < dicValue.Length; i++)
                {
                    string[] splitedValue = dicValue[i].Split(',');

                    dic.Add(splitedValue[0], int.Parse(splitedValue[1]));
                }
                return dic;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                Dictionary<string, int> dic = Parse(value);
                binaryWriter.Write(dic.Count);
                foreach (string key in dic.Keys)
                {
                    binaryWriter.Write(key);
                    binaryWriter.Write(dic[key]);
                }
            }
        }
    }

