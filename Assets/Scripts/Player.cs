using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Timer timer;
    private Vector2 defaultPosition;

    void Start()
    {
        defaultPosition = transform.position;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        Respawn();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            timer.Stop();
        }
    }

    private void Respawn()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Set initial position and rotation
            transform.SetPositionAndRotation(defaultPosition, Quaternion.Euler(0, 0, 0));

            // Remove inertie, to not move and rotate on respawn
            rb.Sleep();

            timer.Reset();
        }
    }
}
