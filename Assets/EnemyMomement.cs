using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyMomement : MonoBehaviour
{
    public Transform jugador; // Referencia al transform del jugador
    public float velocidad = 2.0f;   // Velocidad a la que el enemigo seguirá al jugador


    public GameObject enemyPrefab; // El prefabricado del enemigo 
    public float spawnInterval = 2.0f; // El intervalo de tiempo entre cada generación de enemigos
    public float spawnRadius = 10.0f;

    private float timeSinceLastSpawn = 0.0f;

    public int VidaEnemigo = 100; // Vida inicial del enemigo
    public Slider slider; // Referencia al slider

    private bool estaMuerto = false;

    private void Start()
    {
        // Asegúrate de que el slider tenga el valor inicial correcto
        slider.value = VidaEnemigo;
    }

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


            //timeSinceLastSpawn += Time.deltaTime;

            //if (timeSinceLastSpawn >= spawnInterval)
            //{
            //    SpawnEnemy();
            //    timeSinceLastSpawn = 0.0f;
            //}
        }
    }

    public void RecibirDañoo(int daño)
    {
        if (estaMuerto) return; // Si ya está muerto, no procesar más daño

        VidaEnemigo -= daño;
        slider.value = VidaEnemigo; // Actualiza el slider con la nueva vida

        if (VidaEnemigo <= 0)
        {
            Morir();
        }
    }

    void Morir()
    {
        Destroy(gameObject);
        estaMuerto = true;
    }

    //void SpawnEnemy()
    //{
    //    Vector3 randomPosition = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius));
    //    GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    //}




}


