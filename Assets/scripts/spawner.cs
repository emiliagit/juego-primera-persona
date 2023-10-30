using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    //spawn de enemigos en mapa
    public GameObject enemyPrefab; // El prefabricado del enemigo 
    public float spawnInterval = 8.0f; // El intervalo de tiempo entre cada generación de enemigos
    //private float timeSinceLastSpawn = 0.0f;

    //listas para posicion de enemigos;
    public GameObject[] enemy;
    public Vector3[] spawnPosition;

    //cantidad de enemigos en mapa
    public int maxEnemyCount = 8;
    public int currentEnemyCount = 0;
    // Start is called before the first frame update

    bool spawnerActive = true; //spawner activo
    float delay; //retraso del spawner

    private void Start()
    {
        delay = 10f;
        spawnerActive = true;
        StartCoroutine(timer());
    }

    private IEnumerator timer()
    {
        while (spawnerActive)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(delay);
        }
    }

    private void Update()
    {
        if (currentEnemyCount >= maxEnemyCount)
        {
            spawnerActive = false;
            //Debug.Log("se desactivo spawner");
        }
        if (currentEnemyCount < maxEnemyCount)
        {
            spawnerActive = true;
            //Debug.Log("se activo spawner");
        }
    }

    void SpawnEnemy()
    {
        if (currentEnemyCount < maxEnemyCount)
        {
            currentEnemyCount++;//contador de enemigos

            int randomIndex = Random.Range(0, enemy.Length);
            int randomPosition = Random.Range(0, spawnPosition.Length);

            GameObject randomEnemy = enemy[randomIndex];

            Instantiate(randomEnemy, spawnPosition[randomPosition], randomEnemy.transform.rotation);

        }
    }
}
