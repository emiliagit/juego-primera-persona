using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarEnemy : MonoBehaviour
{
    private int da�o = 20;
    public Slider slider;
    public int Salud = 100;

    public EnemyMomement muerte;

    
    private void Update()
    {
        slider.value = Salud;
    }

    public void takeDa�o(int ValorDa�o)
    {
        Salud -= da�o;
        Debug.Log("da�o");

        if (Salud <= 0)
        {
            muerte.DieEnemy();
        }
    }



    
}
