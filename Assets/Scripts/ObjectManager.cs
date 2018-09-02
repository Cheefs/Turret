using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public TurretUnity TurretUnity { get; private set; }

    void Awake()
    {
        TurretUnity = GetComponentInChildren<TurretUnity>();
    //    Debug.Log(TurretObject.name);
    }
}
