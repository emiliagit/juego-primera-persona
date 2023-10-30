using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    //spawn de enemigos en mapa
    public GameObject enemyPrefab; // El prefabricado del enemigo 
    public float spawnInterval = 8.0f; // El intervalo de tiempo entre cada generación de enemigos
    private float timeSinceLastSpawn = 0.0f;

    //listas para posicion de enemigos;
    public GameObject[] enemy;
    public Vector3[] spawnPosition;

    //cantidad de enemigos en mapa
    public int maxEnemyCount = 6;  
    private int currentEnemyCount = 0;
    // Start is called before the first frame update

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0.0f;
        }
    }
    void SpawnEnemy()
    {
        if (currentEnemyCount < maxEnemyCount)
        {

            int randomQuantity = 1;

            for (int i = 0; i < randomQuantity; i++)
            {
                int randomIndex = Random.Range(0, enemy.Length);
                int randomPosition = Random.Range(0, spawnPosition.Length);

                GameObject randomEnemy = enemy[randomIndex];

                Instantiate(randomEnemy, spawnPosition[randomPosition], randomEnemy.transform.rotation);
                currentEnemyCount++;//contador de enemigos

            }
        }
    }
}
