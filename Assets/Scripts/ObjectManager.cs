using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject TurretObject { get; private set; }

    void Awake()
    {
        TurretObject = gameObject.transform.Find("Turret").GetComponentInChildren<TurretUnity>().gameObject;
    //    Debug.Log(TurretObject.name);
    }
}
