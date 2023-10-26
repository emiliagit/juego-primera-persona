using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class ArmaDisparos : MonoBehaviour
{
     public GameObject balaPrefab; //prefab de la bala
    
    [SerializeField] private Transform puntoDeOrigen; // origen del disparo

    [SerializeField] private float velocidadBala = 10f;
    [SerializeField] private float cadenciaDisparo = 0.5F; //velocidad de disparo

    private float tiempoUltimoDisparo;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time - tiempoUltimoDisparo > cadenciaDisparo) 
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        tiempoUltimoDisparo = Time.time;
        GameObject nuevaBala = Instantiate(balaPrefab, puntoDeOrigen.position, puntoDeOrigen.rotation);
        Rigidbody rb = nuevaBala.GetComponent<Rigidbody>();

        if (rb != null )
        {
            rb.velocity = puntoDeOrigen.forward * velocidadBala;
        }
    }
}
