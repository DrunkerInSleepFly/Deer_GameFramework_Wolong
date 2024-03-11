
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public static class BinaryReaderExtension
{
    public static Color32 ReadColor32(this BinaryReader binaryReader)
    {
        return new Color32(binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte(), binaryReader.ReadByte());
    }

    public static Color ReadColor(this BinaryReader binaryReader)
    {
        return new Color(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static DateTime ReadDateTime(this BinaryReader binaryReader)
    {
        return new DateTime(binaryReader.ReadInt64());
    }

    public static Quaternion ReadQuaternion(this BinaryReader binaryReader)
    {
        return new Quaternion(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static Rect ReadRect(this BinaryReader binaryReader)
    {
        return new Rect(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static Vector2 ReadVector2(this BinaryReader binaryReader)
    {
        return new Vector2(binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static Vector3 ReadVector3(this BinaryReader binaryReader)
    {
        return new Vector3(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static Vector4 ReadVector4(this BinaryReader binaryReader)
    {
        return new Vector4(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
    }

    public static List<Vector2> ReadListVector2(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        List<Vector2> vector2List = new List<Vector2>();
        for (int i = 0; i < listCount; i++)
        {
            vector2List.Add(new Vector2(binaryReader.ReadSingle(), binaryReader.ReadSingle()));
        }
        return vector2List;
    }

    public static List<Vector3> ReadListVector3(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        List<Vector3> vector3List = new List<Vector3>();
        for (int i = 0; i < listCount; i++)
        {
            vector3List.Add(new Vector3(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle()));
        }
        return vector3List;
    }

    public static List<int> ReadListInt(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        List<int> intList = new List<int>();
        for (int i = 0; i < listCount; i++)
        {
            intList.Add(binaryReader.ReadInt32());
        }
        return intList;
    }

    public static List<float> ReadListFloat(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        List<float> floatList = new List<float>();
        for (int i = 0; i < listCount; i++)
        {
            floatList.Add(binaryReader.ReadSingle());
        }
        return floatList;
    }

    public static Dictionary<int, int> ReadDictionaryIntAndInt(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < listCount; i++)
        {
            dic.Add(binaryReader.ReadInt32(), binaryReader.ReadInt32());
        }
        return dic;
    }

    public static Dictionary<int, string> ReadDictionaryIntAndString(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        Dictionary<int, string> dic = new Dictionary<int, string>();
        for (int i = 0; i < listCount; i++)
        {
            dic.Add(binaryReader.ReadInt32(), binaryReader.ReadString());
        }
        return dic;
    }
    public static Dictionary<int, float> ReadDictionaryIntAndFloat(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        Dictionary<int, float> dic = new Dictionary<int, float>();
        for (int i = 0; i < listCount; i++)
        {
            dic.Add(binaryReader.ReadInt32(), binaryReader.ReadSingle());
        }
        return dic;
    }

    public static Dictionary<string, int> ReadDictionaryStringAndInt(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i = 0; i < listCount; i++)
        {
            dic.Add(binaryReader.ReadString(), binaryReader.ReadInt32());
        }
        return dic;
    }

    public static Dictionary<string, string> ReadDictionaryStringAndString(this BinaryReader binaryReader)
    {
        int listCount = binaryReader.ReadInt32();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for (int i = 0; i < listCount; i++)
        {
            dic.Add(binaryReader.ReadString(), binaryReader.ReadString());
        }
        return dic;
    }
}

