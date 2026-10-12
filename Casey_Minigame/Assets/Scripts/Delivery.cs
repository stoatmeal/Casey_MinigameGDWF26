using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public float speed;
    public GameObject[] spawnPoints;
    public GameObject[] rightPivots;
    public GameObject[] leftPivots;
    private int turnIndex;
    private int turnLR;
    private ScoreHandler scoreHandler;


    private void Start()
    {
        scoreHandler = Object.FindFirstObjectByType<ScoreHandler>();
        rightPivots = GameObject.FindGameObjectsWithTag("RightTurn");
        leftPivots = GameObject.FindGameObjectsWithTag("LeftTurn");
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        turnIndex = Random.Range(0, leftPivots.Length);
        turnLR = Random.Range(0, 2);

    }

    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
            float zDifference = Mathf.Abs(transform.position.z - leftPivots[turnIndex].transform.position.z);
            if (zDifference < 1)
            {
                transform.rotation = Quaternion.identity;
                if(turnLR == 0) { transform.rotation *= Quaternion.Euler(0, 90, 0); }
                if (turnLR == 1) { transform.rotation *= Quaternion.Euler(0, -90, 0); }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("House"))
        {
            Destroy(gameObject);
            scoreHandler.HealthGoDown();
        }

    }
}
