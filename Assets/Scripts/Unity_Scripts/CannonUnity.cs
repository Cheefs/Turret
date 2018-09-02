using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonUnity : BaseObject {

    protected override void Awake()
    {
        base.Awake();
    }
    //перенесён в MainManager

    //public CannonModel cannonModel;

    /*
    public void Shoot()
    {
        if (!cannonModel.IsOverheated)
        {
            cannonModel.Shoot();
            //дальше созданиее пули, тип которой мы достаём из canonModel
        }
    }
    */
}
