using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float monsterSpawnInterval = 3.0f;
    public float monster1SpawnPercentage = 0.2f;
    public float monster2SpawnPercentage = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", monsterSpawnInterval, monsterSpawnInterval);
    }

    private void SpawnMonster()
    {
        float random = Random.value;
        monster1SpawnPercentage += 0.03f;
        monster2SpawnPercentage += 0.03f;
        monsterSpawnInterval -= 0.07f;
        if (random < monster1SpawnPercentage)
        {
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
            return;
        }
        else if (random > monster1SpawnPercentage && random < monster1SpawnPercentage + monster2SpawnPercentage)
        {
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
            return;
        }
    }
}
