using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class DictionaryStringAndStringProcessor : GenericDataProcessor<Dictionary<string, string>>
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
                    return "Dictionary<string, string>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "Dictionary<string, string>",
                };
            }

            public override Dictionary<string, string> Parse(string value)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                if (value == "-1")
                    return dic;
                string[] dicValue = value.Split(';');
                for (int i = 0; i < dicValue.Length; i++)
                {
                    string[] splitedValue = dicValue[i].Split(',');

                    dic.Add(splitedValue[0], splitedValue[1]);
                }
                return dic;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                Dictionary<string, string> dic = Parse(value);
                binaryWriter.Write(dic.Count);
                foreach (string key in dic.Keys)
                {
                    binaryWriter.Write(key);
                    binaryWriter.Write(dic[key]);
                }
            }
        }
    }

