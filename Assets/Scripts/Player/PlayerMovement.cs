using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float Speed;

    private Animator animator;
    private Rigidbody2D rb;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movement = new Vector2(moveX, moveY);

    }

    private void FixedUpdate()
    {
        Vector2 velocity = movement.normalized * Speed;
        rb.linearVelocity = velocity;
    }
}
