using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMomement : MonoBehaviour
{

    //movimientos de seguir al jugador
    public Transform jugador; // Referencia al transform del jugador
    public float velocidad = 2.0f;   // Velocidad a la que el enemigo seguirá al jugador

    

    //datos para daño de jugador
    public int daño = 20;
    public VidaJugador VidaPlayer;
    GameObject player;

    //datos para daño de enemigo
    public HealthBarEnemy vida;
    public int Salud = 100;


    private void Update()
    {
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


            
        }
    }


    private void Awake()
    {
        {

            player = GameObject.FindGameObjectWithTag("Player");
            VidaPlayer = VidaPlayer.GetComponent<VidaJugador>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                VidaPlayer.RecibirDaño(daño);
            }

            if (collision.gameObject.CompareTag("bullet"))
            {
                vida.takeDaño(daño);

            }
        }
    }

    public void DieEnemy()
    {
        Destroy(gameObject);
    }

    
        

}


