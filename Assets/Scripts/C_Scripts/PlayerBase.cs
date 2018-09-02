using UnityEngine;
using UnityEngine.UI;

public class PlayerBase
{
    const int MaxHp = 100;
    public int EnemyDmg { get; private set; }
    public static float CurrentValue { get; private set; }

    public PlayerBase(Slider slider)
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
        else {
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
