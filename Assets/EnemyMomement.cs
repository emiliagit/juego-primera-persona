using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMomement : MonoBehaviour
{

    //movimientos de seguir al jugador
    public Transform jugador; // Referencia al transform del jugador
    public float velocidad = 2.0f;   // Velocidad a la que el enemigo seguir� al jugador

    //spawn de enemigos en mapa
    public GameObject enemyPrefab; // El prefabricado del enemigo 
    public float spawnInterval = 2.0f; // El intervalo de tiempo entre cada generaci�n de enemigos
    public float spawnRadius = 10.0f;

    // private float timeSinceLastSpawn = 0.0f;


    


    private void Update()
    {
        {

            //// Verificar si tenemos una referencia al jugador
            //if (jugador == null)
            //{
            //    Debug.LogWarning("No se ha asignado una referencia al jugador.");
            //    return;
            //}

            //// Calcular la direcci�n hacia el jugador
            //Vector3 direccion = jugador.position - transform.position;
            //direccion.Normalize(); // Normalizar para obtener una direcci�n unitaria

            //// Mover al enemigo en la direcci�n del jugador
            //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World); // Usar Space.World para mover en el mundo

            //transform.LookAt(jugador); //hace que mire al jugador


            //timeSinceLastSpawn += Time.deltaTime;

            //if (timeSinceLastSpawn >= spawnInterval)
            //{
            //    SpawnEnemy();
            //    timeSinceLastSpawn = 0.0f;
            //}
        }
    }

    



    //void SpawnEnemy()
    //{
    //    Vector3 randomPosition = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius));
    //    GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    //}




}


