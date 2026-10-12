using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPoints;

    public float delay = 10;
    public static SpawnManager instance { get; private set; }

    void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        StartCoroutine(SpawnLoop());
    }
    IEnumerator SpawnLoop()
    {
        while (true)
        {

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);


            Transform currentSpawn = spawnPoints[spawnPointIndex];
            GameObject Mailman = Instantiate(prefab, currentSpawn.position, currentSpawn.rotation);
            


            yield return new WaitForSeconds(delay);
        }
    }
    public void GoFaster() {
        delay += -.05f;
        if (delay < 1)
        {
            delay = 1;
        }
    }
}
