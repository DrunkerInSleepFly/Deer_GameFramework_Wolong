//using HotfixCommon;
using GameFramework.DataTable;
using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;


public static class GameDataTable
{
    private const string DataRowClassPrefixName = "HotfixFramework.DR";



    public static void LoadDataTable(this DataTableComponent dataTableComponent, string dataTableName, string dataTableAssetName, object userData)
    {
        if (string.IsNullOrEmpty(dataTableName))
        {
            Log.Warning("Data table name is invalid.");
            return;
        }
        string[] splitedNames = dataTableName.Split('_');
        if (splitedNames.Length > 2)
        {
            Log.Warning("Data table name is invalid.");
            return;
        }
        string dataRowClassName = DataRowClassPrefixName + splitedNames[0];
        //Debug.Log(dataRowClassName);
        Type dataRowType = Type.GetType(dataRowClassName);
        if (dataRowType == null)
        {
            Log.Warning("Can not get data row type with class name '{0}'.", dataRowClassName);
            return;
        }
        string name = splitedNames.Length > 1 ? splitedNames[1] : null;
        DataTableBase dataTable = dataTableComponent.CreateDataTable(dataRowType, name);
        dataTable.ReadData(dataTableAssetName,Constant.AssetPriority.DataTableAsset, userData);
    }


}
