using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMomement : MonoBehaviour
{

    //movimientos de seguir al jugador
    private Transform jugador; // Referencia al transform del jugador
    public float velocidad = 2.0f;   // Velocidad a la que el enemigo seguir� al jugador

    //datos para da�o de jugador
    public int da�o = 20;
    private VidaJugador VidaPlayer;
    GameObject player;

    //datos para da�o de enemigo
    public HealthBarEnemy vida;


    private void Update()
    {
        {
            // Verificar si tenemos una referencia al jugador
            if (jugador == null)
            {
                Debug.LogWarning("No se ha asignado una referencia al jugador.");
                return;
            }

            // Calcular la direcci�n hacia el jugador
            Vector3 direccion = jugador.position - transform.position;
            direccion.Normalize(); // Normalizar para obtener una direcci�n unitaria

            // Mover al enemigo en la direcci�n del jugador
            transform.Translate(direccion * velocidad * Time.deltaTime, Space.World); // Usar Space.World para mover en el mundo

            transform.LookAt(jugador); //hace que mire al jugador
        }
    }


    private void Awake()
    {
        {

            player = GameObject.FindGameObjectWithTag("Player");
            VidaPlayer = FindObjectOfType<VidaJugador>();
            jugador = player.transform;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                VidaPlayer.RecibirDa�o(da�o);
            }

            if (collision.gameObject.CompareTag("bullet"))
            {
                vida.takeDa�o(da�o);

            }
        }
    }

    //public void DieEnemy()
    //{
    //    Destroy(gameObject);
    //}

    
        

}


