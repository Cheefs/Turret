using UnityEngine;
using UnityEngine.UI;

public class Base_Controller : Base_Model
{
    public static float CurrentValue { get; private set; }

    readonly int EnemyDmg = 10;

    public Base_Controller(Slider slider)
    {
        CurrentValue = MaxHp;
        slider.maxValue = MaxHp;
        slider.minValue = 0;
        slider.value = CurrentValue;
        slider.fillRect.GetComponent<Image>().color = Color.green;
    }

    public bool GetDamage()
    {
        if (CurrentValue < 0) GameEnd();
        else
        {
            CurrentValue -= EnemyDmg;
        }
        return true;
    }

    public void GameEnd()
    {
    }

    public void RegenerateHp()
    {
        if (CurrentValue < MaxHp && GetDamage() == false) CurrentValue += 0.1f;
    }
}

