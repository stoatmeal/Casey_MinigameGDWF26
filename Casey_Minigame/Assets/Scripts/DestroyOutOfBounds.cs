using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float Duration;

    void Update()
    {
        Destroy(gameObject, Duration);
    }
}
