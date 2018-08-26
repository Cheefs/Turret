using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonModel {

    public Enum_CannonTipe CannonTipe { get; private set; }

    public BulletModel BulletTipe { get; set; }

    public float Overheat { get; private set; }

    public bool IsOverheated { get; private set; }

    //стандартный конструктор будет создавать объект "Ствол" типа FireBarrel
    public CannonModel()
    {
        CannonTipe = Enum_CannonTipe.FireCannon;
        BulletTipe = BulletTipe;
        // Debug.Log("Создана турель типа FireBarrel");   (проверка инициализации турелей)
    }

    //второй конструктор создаёт объект "Ствол" переданного типа
    public CannonModel(Enum_CannonTipe cannonTipe)
    {
        CannonTipe = cannonTipe;
    }

    public void Shoot()
    {
        Debug.Log("Тип снаряда:");
        Debug.Log(BulletTipe);
    }
}
