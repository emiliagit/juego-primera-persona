using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMomement : MonoBehaviour
{
    public Transform jugador; // Referencia al transform del jugador
    public float velocidad = 5.0f; // Velocidad a la que el enemigo seguirá al jugador

    private void Update()
    {
        // Verificar si tenemos una referencia al jugador
        if (jugador == null)
        {
            Debug.LogWarning("No se ha asignado una referencia al jugador.");
            return;
        }

        // Calcular la dirección hacia el jugador
        Vector3 direccion = jugador.position - transform.position;
        direccion.Normalize(); // Normalizar para obtener una dirección unitaria

        // Mover al enemigo en la dirección del jugador
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World); // Usar Space.World para mover en el mundo

        transform.LookAt(jugador); //hace que mire al jugador


        // Mover al enemigo en la dirección del jugador

    }
}


