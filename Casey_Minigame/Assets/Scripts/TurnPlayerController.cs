using UnityEngine;
using UnityEngine.InputSystem;

public class TurnPlayerController : MonoBehaviour
{
    public float speed;
    public InputAction fireAction;
    public GameObject projectilePrefab;
    public Transform spawn;
    void Start()
    {
        fireAction.Enable();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
        }
        if (fireAction.triggered)
        {
            Instantiate(projectilePrefab, spawn.transform.position, gameObject.transform.rotation);
        }
    }
}
