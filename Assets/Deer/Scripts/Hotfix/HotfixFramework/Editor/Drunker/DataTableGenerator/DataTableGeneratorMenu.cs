using GameFramework;
using System.IO;
using UnityEditor;
using UnityEngine;



    /// <summary>
    /// 
    /// </summary>
    public sealed class DataTableGeneratorMenu
    {
        private static string DataTablePath = "Assets/Deer/DataTables/";
        [MenuItem("GameTools/Generate DataTables/CS_Bytes", priority = 100)]
        private static void GenerateDataTables()
        {
            //判断路径是否存在
            if (Directory.Exists(DataTablePath))
            {
                DirectoryInfo dir = new DirectoryInfo(DataTablePath);
                ////获取目标路径下的所有文件与文件夹
                //FileSystemInfo[] allFilesAndDir = dir.GetFileSystemInfos("*", SearchOption.AllDirectories);
                //获取目标路径下的所有文件
                FileInfo[] allFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);
                //获取目标路径下的单层文件
                //FileInfo[] files = dir.GetFiles("*");
                ////获取目标路径下的所有文件夹
                //DirectoryInfo[] allDirs = dir.GetDirectories("*", SearchOption.AllDirectories);
                ////获取目标路径下的单层文件夹
                //DirectoryInfo[] dirs = dir.GetDirectories("*");
                foreach (var item in allFiles)
                {
                    //Debug.Log(item.Name);
                    string dataTableName = item.Name.Substring(0, item.Name.Length - 4);
                    Debug.Log(dataTableName);
                    DataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
                    if (!DataTableGenerator.CheckRawData(dataTableProcessor, dataTableName))
                    {
                        Debug.LogError(Utility.Text.Format("Check raw data failure. DataTableName='{0}'", dataTableName));
                        break;
                    }

                    DataTableGenerator.GenerateByteDataFile(dataTableProcessor, dataTableName);
                    DataTableGenerator.GenerateCodeFile(dataTableProcessor, dataTableName);
                    File.Delete(Utility.Path.GetRegularPath(item.FullName));
                }
            }
            AssetDatabase.Refresh();
        }
        [MenuItem("GameTools/Generate DataTables/GenerateBytes", priority = 100)]
        private static void GenerateDataTableBytes()
        {
            //判断路径是否存在
            if (Directory.Exists(DataTablePath))
            {
                DirectoryInfo dir = new DirectoryInfo(DataTablePath);
                ////获取目标路径下的所有文件与文件夹
                //FileSystemInfo[] allFilesAndDir = dir.GetFileSystemInfos("*", SearchOption.AllDirectories);
                //获取目标路径下的所有文件
                FileInfo[] allFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);
                //获取目标路径下的单层文件
                //FileInfo[] files = dir.GetFiles("*");
                ////获取目标路径下的所有文件夹
                //DirectoryInfo[] allDirs = dir.GetDirectories("*", SearchOption.AllDirectories);
                ////获取目标路径下的单层文件夹
                //DirectoryInfo[] dirs = dir.GetDirectories("*");
                foreach (var item in allFiles)
                {
                    //Debug.Log(item.Name);
                    string dataTableName = item.Name.Substring(0, item.Name.Length - 4);
                    Debug.Log(dataTableName);
                    DataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
                    if (!DataTableGenerator.CheckRawData(dataTableProcessor, dataTableName))
                    {
                        Debug.LogError(Utility.Text.Format("Check raw data failure. DataTableName='{0}'", dataTableName));
                        break;
                    }

                    DataTableGenerator.GenerateByteDataFile(dataTableProcessor, dataTableName);
                    File.Delete(Utility.Path.GetRegularPath(item.FullName));
                }
            }
            AssetDatabase.Refresh();
        }

        [MenuItem("GameTools/Generate DataTables/CS_Txt", priority = 200)]
        private static void GenerateDataTablesTxt()
        {
            //判断路径是否存在
            if (Directory.Exists(DataTablePath))
            {
                DirectoryInfo dir = new DirectoryInfo(DataTablePath);
                ////获取目标路径下的所有文件与文件夹
                //FileSystemInfo[] allFilesAndDir = dir.GetFileSystemInfos("*", SearchOption.AllDirectories);
                //获取目标路径下的所有文件
                FileInfo[] allFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);
                //获取目标路径下的单层文件
                //FileInfo[] files = dir.GetFiles("*");
                ////获取目标路径下的所有文件夹
                //DirectoryInfo[] allDirs = dir.GetDirectories("*", SearchOption.AllDirectories);
                ////获取目标路径下的单层文件夹
                //DirectoryInfo[] dirs = dir.GetDirectories("*");
                foreach (var item in allFiles)
                {
                    //Debug.Log(item.Name);
                    string dataTableName = item.Name.Substring(0, item.Name.Length - 4);
                    Debug.Log(dataTableName);
                    DataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
                    if (!DataTableGenerator.CheckRawData(dataTableProcessor, dataTableName))
                    {
                        Debug.LogError(Utility.Text.Format("Check raw data failure. DataTableName='{0}'", dataTableName));
                        break;
                    }

                    DataTableGenerator.CopyTxtFiles(dataTableProcessor, dataTableName);
                    DataTableGenerator.GenerateCodeFile(dataTableProcessor, dataTableName);
                    File.Delete(Utility.Path.GetRegularPath(item.FullName));
                }
            }
            AssetDatabase.Refresh();
        }

        [MenuItem("GameTools/Generate DataTables/CopyTxt", priority = 200)]
        private static void GenerateDataTablesCopyTxt()
        {
            //判断路径是否存在
            if (Directory.Exists(DataTablePath))
            {
                DirectoryInfo dir = new DirectoryInfo(DataTablePath);
                ////获取目标路径下的所有文件与文件夹
                //FileSystemInfo[] allFilesAndDir = dir.GetFileSystemInfos("*", SearchOption.AllDirectories);
                //获取目标路径下的所有文件
                FileInfo[] allFiles = dir.GetFiles("*.txt", SearchOption.AllDirectories);
                //获取目标路径下的单层文件
                //FileInfo[] files = dir.GetFiles("*");
                ////获取目标路径下的所有文件夹
                //DirectoryInfo[] allDirs = dir.GetDirectories("*", SearchOption.AllDirectories);
                ////获取目标路径下的单层文件夹
                //DirectoryInfo[] dirs = dir.GetDirectories("*");
                foreach (var item in allFiles)
                {
                    //Debug.Log(item.Name);
                    string dataTableName = item.Name.Substring(0, item.Name.Length - 4);
                    DataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
                    if (!DataTableGenerator.CheckRawData(dataTableProcessor, dataTableName))
                    {
                        Debug.LogError(Utility.Text.Format("Check raw data failure. DataTableName='{0}'", dataTableName));
                        break;
                    }

                    DataTableGenerator.CopyTxtFiles(dataTableProcessor, dataTableName);
                    File.Delete(Utility.Path.GetRegularPath(item.FullName));
                }
            }
            AssetDatabase.Refresh();
        }
    }

