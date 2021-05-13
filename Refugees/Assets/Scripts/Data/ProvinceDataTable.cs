using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

/// <summary>
/// 游戏数据配置表
/// </summary>


[InlineEditor]
[CreateAssetMenu(fileName="ProvinceDataTable",menuName="游戏数据表/省份数据表",order=0)]
public class ProvinceDataTable : ScriptableObject
{
    [TableList(ShowIndexLabels = true)]
    public List<ProvinceData> provinceDataTable;
}
