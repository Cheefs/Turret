using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUnity : BaseObject
{
    public GameObject[] CannonObjects { get; private set; }

    private TurretModel turretModel;

    protected override void Awake()
    {
        base.Awake();
        turretModel = new TurretModel();

        #region FindCannonObjects
        CannonObjects = new GameObject[4];

        int i = 0;

        foreach (var cannon in GameObject.GetComponentsInChildren<CannonUnity>())
        {
            CannonObjects[i] = cannon.gameObject;
            // cannon.cannonModel = turretModel.Cannons[i];  (будет нужно, если мы будем хранить в классе Unity_Cannon ссылку на CannonModel, находящийся в TurretModel)
            i++;
            // Debug.Log(cannon.gameObject.name);  //  (проверка нахождения всех стволов в Unity)
            // Debug.Log(i);
            // Debug.Log(cannon.cannonModel.CannonTipe);  //  (проверка нахождения всех стволов в Unity)
        }
        #endregion
    }

    
}
