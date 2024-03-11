using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class ListFloatProcessor : GenericDataProcessor<List<float>>
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
                    return "List<float>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "list.float",
                    "unityengine.list.float"
                };
            }

            public override List<float> Parse(string value)
            {
                List<float> listfloat = new List<float>();
                if (value == "-1")
                    return listfloat;
                string[] intValue = value.Split(',');
                for (int i = 0; i < intValue.Length; i++)
                {
                    listfloat.Add(float.Parse(intValue[0]));
                }
                return listfloat;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                List<float> listint = Parse(value);
                binaryWriter.Write(listint.Count);
                for (int i = 0; i < listint.Count; i++)
                {
                    binaryWriter.Write(listint[i]);
                }
            }
        }
    }

