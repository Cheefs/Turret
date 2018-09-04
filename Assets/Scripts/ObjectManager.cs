using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public TurretUnity TurretUnity { get; private set; }

    private CameraMove _camera;

    void Awake()
    {
        TurretUnity = GetComponentInChildren<TurretUnity>();
        _camera = GetComponentInChildren<CameraMove>();
    //    Debug.Log(TurretObject.name);
    }

    private void Update()
    {
        _camera.RotateView();
    }
}
