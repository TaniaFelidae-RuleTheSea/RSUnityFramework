using System;
using UnityEngine;

public class GameData
{
    public ChipData[] chips;   
}
[Serializable]
public struct ChipData
{
    public int id;
    public string name;
    public Sprite sprite;
    public int betamount;
}
