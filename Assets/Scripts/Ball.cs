using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveForce;
    float xInput, zInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        Move();
    }

    void Move()
    {
        rb.AddForce(new Vector3(xInput, 0, zInput) * moveForce);
    }
}
