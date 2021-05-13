using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

/// <summary>
/// 游戏数据
/// </summary>
[CreateAssetMenu(fileName="ProvinceData",menuName="游戏数据/基本数据/省份数据",order=0)]
public class ProvinceData : ScriptableObject
{

    [PreviewField(80,ObjectFieldAlignment.Left)]
    [HideLabel]
    [HorizontalGroup("Data",100)]
    public Sprite icon;

    [VerticalGroup("Data/ProvinceData"),LabelWidth(70)]
    [GUIColor(0.3f,0.8f,0.8f,1)]
    public string Name;

    
    [VerticalGroup("Data/ProvinceData"),LabelWidth(70)]
    [GUIColor(0.3f,0.8f,0.8f,1)]
    public string synopsis;

    [GUIColor(0.3f,0.8f,0.8f,1)]
    [VerticalGroup("Data/ProvinceData"),LabelWidth(70)]
    public string region;

    
    [VerticalGroup("Data/ProvinceData"),LabelWidth(70)]
    [GUIColor(0.3f,0.8f,0.8f,1)]
    public float number;

    [GUIColor(0.3f,0.8f,0.8f,1)]
    [VerticalGroup("Data/ProvinceData"),LabelWidth(70)]
    public float area;
}
