using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float accelerationDuration = 3f;

    private Rigidbody rb;
    private float baseSpeed;
    private float accelerationTime = 0f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        baseSpeed = moveSpeed;
    }

    void Update()
    {
        // Перевірка на землю
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        // Стрибок
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Прискорення
        if (Input.GetKey(KeyCode.LeftShift) && accelerationTime < accelerationDuration)
        {
            accelerationTime += Time.deltaTime;
            moveSpeed = baseSpeed * 2f;
        }
        else
        {
            moveSpeed = baseSpeed;
            accelerationTime = 0f;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Обчислюємо напрямок руху ВІДНОСНО гравця
        Vector3 move = transform.right * h + transform.forward * v;
        Vector3 velocity = move.normalized * moveSpeed;
        velocity.y = rb.linearVelocity.y;  // не змінюємо вертикальну швидкість (гравітація)

        rb.linearVelocity = velocity;
    }
}
