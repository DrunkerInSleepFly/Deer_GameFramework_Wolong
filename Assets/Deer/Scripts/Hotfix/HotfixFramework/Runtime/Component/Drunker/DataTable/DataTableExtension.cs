using System.Collections.Generic;
using UnityEngine;


public static class DataTableExtension
{
    public static readonly char[] DataSplitSeparators = new char[] { '\t' };
    public static readonly char[] DataTrimSeparators = new char[] { '\"' };

    public static Color32 ParseColor32(string value)
    {
        if (value == "-1")
            return Color.white;
        string[] splitedValue = value.Split(',');
        return new Color32(byte.Parse(splitedValue[0]), byte.Parse(splitedValue[1]), byte.Parse(splitedValue[2]), byte.Parse(splitedValue[3]));
    }

    public static Color ParseColor(string value)
    {
        if (value == "-1")
            return Color.white;
        string[] splitedValue = value.Split(',');
        return new Color(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]), float.Parse(splitedValue[3]));
    }

    public static Quaternion ParseQuaternion(string value)
    {
        if (value == "-1")
            return new Quaternion();
        string[] splitedValue = value.Split(',');
        return new Quaternion(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]), float.Parse(splitedValue[3]));
    }

    public static Rect ParseRect(string value)
    {
        if (value == "-1")
            return new Rect();
        string[] splitedValue = value.Split(',');
        return new Rect(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]), float.Parse(splitedValue[3]));
    }

    public static Vector2 ParseVector2(string value)
    {
        if (value == "-1")
            return Vector2.zero;
        string[] splitedValue = value.Split(',');
        return new Vector2(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]));
    }

    public static Vector3 ParseVector3(string value)
    {
        if (value == "-1")
            return Vector3.zero;
        string[] splitedValue = value.Split(',');
        return new Vector3(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]));
    }

    public static Vector4 ParseVector4(string value)
    {
        if (value == "-1")
            return Vector4.zero;
        string[] splitedValue = value.Split(',');
        return new Vector4(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2]), float.Parse(splitedValue[3]));
    }

    public static List<Vector3> ParseListVector3(string value)
    {
        List<Vector3> vector3List = new List<Vector3>();
        if (value == "-1")
            return vector3List;
        string[] vector3Value = value.Split(';');
        for (int i = 0; i < vector3Value.Length; i++)
        {
            string[] splitedValue = vector3Value[i].Split(',');
            vector3List.Add(new Vector3(float.Parse(splitedValue[0]), float.Parse(splitedValue[1]), float.Parse(splitedValue[2])));
        }
        return vector3List;
    }

    public static List<Vector2> ParseListVector2(string value)
    {
        List<Vector2> vector2List = new List<Vector2>();
        if (value == "-1")
            return vector2List;
        string[] vector3Value = value.Split(';');
        for (int i = 0; i < vector3Value.Length; i++)
        {
            string[] splitedValue = vector3Value[i].Split(',');
            vector2List.Add(new Vector2(float.Parse(splitedValue[0]), float.Parse(splitedValue[1])));
        }
        return vector2List;
    }

    public static List<int> ParseListInt(string value)
    {
        List<int> listInt = new List<int>();
        if (value == "-1")
            return listInt;
        string[] intValue = value.Split(',');
        for (int i = 0; i < intValue.Length; i++)
        {
            listInt.Add(int.Parse(intValue[i]));
        }
        return listInt;
    }
    public static List<float> ParseListFloat(string value)
    {
        List<float> listfloat = new List<float>();
        if (value == "-1")
            return listfloat;
        string[] floatValue = value.Split(',');
        for (int i = 0; i < floatValue.Length; i++)
        {
            listfloat.Add(float.Parse(floatValue[i]));
        }
        return listfloat;
    }
    public static Dictionary<int, int> ParseDictionaryIntAndInt(string value)
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
    public static Dictionary<int, string> ParseDictionaryIntAndString(string value)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        if (value == "-1")
            return dic;
        string[] dicValue = value.Split(';');
        for (int i = 0; i < dicValue.Length; i++)
        {
            string[] splitedValue = dicValue[i].Split(',');
            dic.Add(int.Parse(splitedValue[0]), splitedValue[1]);
        }
        return dic;
    }
    public static Dictionary<int, float> ParseDictionaryIntAndFloat(string value)
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
    public static Dictionary<string, int> ParseDictionaryStringAndInt(string value)
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
    public static Dictionary<string, string> ParseDictionaryStringAndString(string value)
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
}
