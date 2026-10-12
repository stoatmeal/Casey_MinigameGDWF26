using System.Collections;
using UnityEngine;

public class SLIST2 : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] spawnPoints;

    public float delay;
    
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

            int randomIndex = Random.Range(0, spawnPoints.Length);

            Transform currentSpawn = spawnPoints[randomIndex];
            Instantiate(prefab, currentSpawn.position, currentSpawn.rotation);

            yield return new WaitForSeconds(delay);
        }
    }
}
