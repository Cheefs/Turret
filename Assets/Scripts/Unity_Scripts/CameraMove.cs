using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : BaseObject
{
    private HorizontalRotateIndicator HorizontalCameraRotationObject;

    private MouseLook mouseLook;

    protected override void Awake()
    {
        base.Awake();
        mouseLook = new MouseLook();
        HorizontalCameraRotationObject = GetComponentInParent<HorizontalRotateIndicator>();
        mouseLook.Init(Transform, HorizontalCameraRotationObject.Transform);
    }

    public void RotateView()
    {
        mouseLook.LookRotation(Transform, HorizontalCameraRotationObject.Transform);
    }
}
