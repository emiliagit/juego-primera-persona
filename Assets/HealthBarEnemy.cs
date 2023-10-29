using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarEnemy : MonoBehaviour
{
    private int daño = 20;
    public Slider slider;
    public int Salud = 100;

    public EnemyMomement muerte;

    
    private void Update()
    {
        slider.value = Salud;
    }

    public void takeDaño(int ValorDaño)
    {
        Salud -= daño;
        Debug.Log("daño");

        if (Salud <= 0)
        {
            muerte.DieEnemy();
        }
    }



    
}
