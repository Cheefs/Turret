using UnityEngine;
using UnityEngine.UI;

public class Unity_Base : MonoBehaviour
{
    public static Slider slider;
    Base_Controller playerBase = new Base_Controller(slider);

    void OncollisuonEnter(Collision collision)
    {
        playerBase.GetDamage();
    }
}
