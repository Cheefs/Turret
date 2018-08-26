using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel {

    public float Speed { get; set; }

    public Enum_DamageTipe damageTipe; 

    public Time LifeTime { get; private set; }

    //конструктор для тестов
    public BulletModel()
    {
        damageTipe = Enum_DamageTipe.Fire;
    }

    //нормальный конструктор
    public BulletModel(float speed, Enum_CannonTipe cannonTipe, Time lifeTime)
    {
        Speed = speed;
        //this.damageTipe = damageTipe;
        LifeTime = lifeTime;
    }
}
