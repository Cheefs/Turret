using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : BaseObject
{
    [SerializeField]
    private Camera MainCamera;

    [SerializeField]
    private GameObject HorizontalCameraRotationObject;

    private MouseLook mouseLook;

    protected override void Awake()
    {
        base.Awake();
        mouseLook = new MouseLook();
        mouseLook.Init(MainCamera.transform, HorizontalCameraRotationObject.transform);
    }

    private void Update()
    {
        RotateView();
    }

    private void RotateView()
    {
        mouseLook.LookRotation(MainCamera.transform, HorizontalCameraRotationObject.transform);
    }
}
