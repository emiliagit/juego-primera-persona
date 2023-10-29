using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarEnemy : MonoBehaviour
{

    public int VidaEnemigo;
    public Slider slider;

    private void Update()
    {
        slider.value = VidaEnemigo;
    }
}
