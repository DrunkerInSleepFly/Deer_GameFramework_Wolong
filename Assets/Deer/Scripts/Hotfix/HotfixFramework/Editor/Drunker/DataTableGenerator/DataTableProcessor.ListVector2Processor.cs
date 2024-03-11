using System.Collections.Generic;
using System.IO;
using UnityEngine;



    public sealed partial class DataTableProcessor
    {
        private sealed class ListVector2Processor : GenericDataProcessor<List<Vector2>>
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
                    return "List<Vector2>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "list.vector2",
                    "unityengine.list.vector2"
                };
            }

            public override List<Vector2> Parse(string value)
            {
                List<Vector2> listVector2 = new List<Vector2>();
                if (value == "-1")
                    return listVector2;
                string[] vertor2Value = value.Split(';');
                for (int i = 0; i < vertor2Value.Length; i++)
                {
                    string[] splitedValue = vertor2Value[i].Split(',');
                    Vector2 vector2 = new Vector2(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]));
                    listVector2.Add(vector2);
                }
                return listVector2;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                List<Vector2> listVector2 = Parse(value);
                binaryWriter.Write(listVector2.Count);
                for (int i = 0; i < listVector2.Count; i++)
                {
                    Vector3 vector2 = listVector2[i];
                    binaryWriter.Write(vector2.x);
                    binaryWriter.Write(vector2.y);
                }
            }
        }
    }

