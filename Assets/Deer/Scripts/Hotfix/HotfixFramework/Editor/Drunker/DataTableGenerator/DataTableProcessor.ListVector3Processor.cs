using System.Collections.Generic;
using System.IO;
using UnityEngine;



    public sealed partial class DataTableProcessor
    {
        private sealed class ListVector3Processor : GenericDataProcessor<List<Vector3>>
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
                    return "List<Vector3>";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "list.vector3",
                    "unityengine.list.vector3"
                };
            }

            public override List<Vector3> Parse(string value)
            {
                List<Vector3> listVector3 = new List<Vector3>();
                if (value == "-1")
                    return listVector3;
                string[] vertor3Value = value.Split(';');
                for (int i = 0; i < vertor3Value.Length; i++)
                {
                    string[] splitedValue = vertor3Value[i].Split(',');
                    Vector3 vector3 = new Vector3(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]));
                    listVector3.Add(vector3);
                }
                return listVector3;
            }

            public override void WriteToStream(DataTableProcessor dataTableProcessor, BinaryWriter binaryWriter, string value)
            {
                List<Vector3> listVector3 = Parse(value);
                binaryWriter.Write(listVector3.Count);
                for (int i = 0; i < listVector3.Count; i++)
                {
                    Vector3 vector3 = listVector3[i];
                    binaryWriter.Write(vector3.x);
                    binaryWriter.Write(vector3.y);
                    binaryWriter.Write(vector3.z);
                }
            }
        }
    }

