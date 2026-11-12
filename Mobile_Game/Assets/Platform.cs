using UnityEngine;

public class Platform : MonoBehaviour
{
    //allows me to assign the limit between left and right side of the screen so the platform runs off screen
    public GameObject leftlimit;
    public GameObject rightlimit;
    public float moveSpeed = 1.0f;
    Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    enum State
    {
        LEFT, RIGHT
    }
    State state = State.LEFT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.LEFT)
        {
            rb.linearVelocityX = -moveSpeed;
            spriteRenderer.flipX = true;

            if (transform.position.x < leftlimit.transform.position.x)
            {
                state = State.RIGHT;
            }
        }

        else if (state == State.RIGHT)
        {
            rb.linearVelocityX = moveSpeed;
            spriteRenderer.flipX = false;

            if (transform.position.x > rightlimit.transform.position.x)
            {
                state = State.LEFT;
            }
        }
    }
}
