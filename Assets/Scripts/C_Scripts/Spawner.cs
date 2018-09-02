using UnityEngine;
using System.Collections.Generic;
using System.Collections;

class Spawner : MonoBehaviour
{

    List<Transform> enemySpawn = new List<Transform>();
    List<GameObject> enemyType = new List<GameObject>();

    private int amountEnemies = 5;
    private readonly float minTime = 1;
    private float maxTime = 30;
    public int enemys = 0;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < amountEnemies; i++)
        {
            GameObject enemy = enemyType[Random.Range(0, enemyType.Count)];
            Transform pos = enemySpawn[Random.Range(0, enemySpawn.Count)];

            if (enemys < amountEnemies)
            {
                Instantiate(enemy, pos.position, pos.rotation);
                enemys += 1;
            }

            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        }
    }

    private void AddEnemys()
    {
        //if (Turret.LvlUp())
        //{
        //    amountEnemies += amountEnemies;
        //    maxTime -= 0.2f;
        //}
    }
}

