using UnityEngine;

public class BarkKill : MonoBehaviour
{
    private SpawnManager spawnManager;
    private void Start()
    {
        spawnManager = Object.FindFirstObjectByType<SpawnManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("victim"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            spawnManager.GoFaster();
        }
        
    }
}
