using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveForce;
    [SerializeField] float jumpForce;
    bool isGrounded = false;
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

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            Jump();
        }
    }
    void Move()
    {
        rb.AddForce(new Vector3(xInput, 0, zInput) * moveForce);
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }
}
