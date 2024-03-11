using System.Collections.Generic;
using System.IO;



    public sealed partial class DataTableProcessor
    {
        private sealed class ListIntProcessor : GenericDataProcessor<List<int>>
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
                    return "List<int>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "list.int",
                    "unityengine.list.int"
                };
            }

            public override List<int> Parse(string value)
            {
                List<int> listint = new List<int>();
                if (value == "-1")
                    return listint;
                string[] intValue = value.Split(',');
                for (int i = 0; i < intValue.Length; i++)
                {
                    listint.Add(int.Parse(intValue[0]));
                }
                return listint;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                List<int> listint = Parse(value);
                binaryWriter.Write(listint.Count);
                for (int i = 0; i < listint.Count; i++)
                {
                    binaryWriter.Write(listint[i]);
                }
            }
        }
    }

