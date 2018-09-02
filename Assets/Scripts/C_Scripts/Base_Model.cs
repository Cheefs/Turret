using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Модель элемента база, которую защищает турель
/// </summary>
public class Base_Model
{
    public int PosX { get; private set; }
    public int PosY { get; private set; }
    protected int MaxHp { get; private set; }
}
