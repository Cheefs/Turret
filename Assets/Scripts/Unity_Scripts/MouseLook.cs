﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook
{
    public float XSensitivity = 1f;
    public float YSensitivity = 1f;
    public bool clampXYRotation = true;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    public bool smooth;
    public float smoothTime = 5f;
   // public bool lockCursor = true;


   // private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    private Quaternion m_HorizontalCameraRotation;

    private bool m_cursorIsLocked = true;

    public void Init( Transform camera,Transform xRotationObject) //Transform character,
    {
        m_HorizontalCameraRotation = xRotationObject.localRotation;
        m_CameraTargetRot = camera.localRotation;

        smooth = false;
    }


    public void LookRotation( Transform camera, Transform RotationX) //Transform character,
    {
        float yRot = Input.GetAxis("Mouse X") * XSensitivity;
        float xRot = Input.GetAxis("Mouse Y") * YSensitivity;

       // Debug.Log(Input.GetAxis("Mouse X"));

        m_CameraTargetRot *= Quaternion.Euler(0f, yRot, 0f);
        m_HorizontalCameraRotation *= Quaternion.Euler(-xRot, 0f, 0f);



         if (clampXYRotation)
        {
            m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
        }


        if (smooth)
        {

            RotationX.localRotation = Quaternion.Slerp(RotationX.localRotation, m_HorizontalCameraRotation,
                smoothTime * Time.deltaTime);
                
            camera.localRotation = Quaternion.Slerp(camera.localRotation, m_CameraTargetRot,
                smoothTime * Time.deltaTime);
        }
        else
        {
            camera.localRotation = m_CameraTargetRot;
            RotationX.localRotation = m_HorizontalCameraRotation;
        }

       // UpdateCursorLock();
    }
/*
    public void SetCursorLock(bool value)
    {
        lockCursor = value;
        if (!lockCursor)
        {//we force unlock the cursor if the user disable the cursor locking helper
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
*/
/*
    public void UpdateCursorLock()
    {
        //if the user set "lockCursor" we check & properly lock the cursos
        if (lockCursor)
            InternalLockUpdate();
    }
*/
/*
    private void InternalLockUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            m_cursorIsLocked = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_cursorIsLocked = true;
        }

        if (m_cursorIsLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (!m_cursorIsLocked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    */
    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }

}
