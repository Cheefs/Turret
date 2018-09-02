using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {


    public PlayerBase _base;
    public Slider slider;

    public GameObject TurretObject { get; private set; }

    public GameObject[] CannonObjects { get; private set; }

    public TurretModel turretModel;

    [SerializeField] public Camera MainCamera;

    [SerializeField] public GameObject HorizontalCameraRotationObject;

    private MouseLook mouseLook;


    void Start () {

        _base = new PlayerBase(slider);

        TurretObject = gameObject.GetComponentInChildren<Unity_Turret>().gameObject;
        turretModel = new TurretModel();

        #region FindCannonObjects
        CannonObjects = new GameObject[4];

        if (TurretObject!=null)
        {
            int i = 0;
            foreach (var cannon in TurretObject.GetComponentsInChildren<Unity_Cannon>())
            {
                CannonObjects[i] = cannon.gameObject;
                // cannon.cannonModel = turretModel.Cannons[i];  (будет нужно, если мы будем хранить в классе Unity_Cannon ссылку на CannonModel, находящийся в TurretModel)
                i++;
                // Debug.Log(cannon.gameObject.name);  //  (проверка нахождения всех стволов в Unity)
                // Debug.Log(i);
                // Debug.Log(cannon.cannonModel.CannonTipe);  //  (проверка нахождения всех стволов в Unity)
            }
        }
        #endregion

        mouseLook = new MouseLook();
        mouseLook.Init(MainCamera.transform,HorizontalCameraRotationObject.transform);

    }

    private void Update()
    {
        _base.RegenerateHp();

        RotateView();
    }


    private void RotateView()
    {
        mouseLook.LookRotation( MainCamera.transform, HorizontalCameraRotationObject.transform); //transform,
    }
}
