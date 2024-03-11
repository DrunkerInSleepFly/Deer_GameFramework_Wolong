using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class DictionaryIntAndFloatProcessor : GenericDataProcessor<Dictionary<int, float>>
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
                    return "Dictionary<int, float>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "Dictionary<int, float>",
                };
            }

            public override Dictionary<int, float> Parse(string value)
            {
                Dictionary<int, float> dic = new Dictionary<int, float>();
                if (value == "-1")
                    return dic;
                string[] dicValue = value.Split(';');
                for (int i = 0; i < dicValue.Length; i++)
                {
                    string[] splitedValue = dicValue[i].Split(',');

                    dic.Add(int.Parse(splitedValue[0]), float.Parse(splitedValue[1]));
                }
                return dic;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                Dictionary<int, float> dic = Parse(value);
                binaryWriter.Write(dic.Count);
                foreach (int key in dic.Keys)
                {
                    binaryWriter.Write(key);
                    binaryWriter.Write(dic[key]);
                }
            }
        }
    }

