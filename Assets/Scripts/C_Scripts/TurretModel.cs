using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretModel  {

    public CannonModel[] Cannons { get; private set; }

    //public float rotationRate; (скорость поворота турели, если понадобится)

    //стандартный конструктор без указания типов турелей , по умолчанию будут все типа FireCannon
    public TurretModel()
    {
        Cannons = new CannonModel[4];

        for (int i = 0; i < Cannons.Length; i++)
        {
            Cannons[i] = new CannonModel();
        }
    }

    public void Fire()
    {
        foreach (CannonModel cannon in Cannons)
        {
            cannon.Shoot();
        }
    }

    public void ChangeCannonTipe()
    {

    }
	
}
