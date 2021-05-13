using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;
using System.Linq;

/// <summary>
///  游戏数据配置表功能模块
/// </summary>


[InlineEditor]
public class ModuleTesting : MonoBehaviour
{

    [FoldoutGroup("省份数据表")]
    [HideLabel]
    public ProvinceDataTable province;



    private void Start()
    {

    }



    [Button("查找")]
    public void SearchTable(TableName TableName,DataTableType dataTableType)
    {      
        foreach(ProvinceData provinceData in province.provinceDataTable)
        {
            if(provinceData.name==TableName.ToString())
            {
                switch (dataTableType)
                {
                    case DataTableType.Icon:
                    Debug.Log(provinceData.icon);
                    break;

                    case DataTableType.Name:
                    Debug.Log(provinceData.Name);
                    break;

                    case DataTableType.Synopsis:
                    Debug.Log(provinceData.synopsis);
                    break;

                    case DataTableType.Region:
                    Debug.Log(provinceData.region);
                    break;

                    case DataTableType.Number:
                    Debug.Log(provinceData.number);
                    break;

                    case DataTableType.Area:
                    Debug.Log(provinceData.area);
                    break;
                }
            }
        }
    }

}

public enum DataTableType
{
    Icon,
    Name,
    Synopsis,
    Region,
    Number,
    Area
}

public enum TableName
{
    ZheJiang,
    HeNan
}
