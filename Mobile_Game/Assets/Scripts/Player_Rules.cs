using UnityEngine;

public class Player_Rules : MonoBehaviour
{
    public Camera cam;
    public Rigidbody2D rb;
    public SpriteRenderer sprite;

    private float xmin, xmax;
    private float spriteWidth;
    float cameraBounds;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteWidth = sprite.bounds.size.x * 0.5f;
        float camwidth = cam.orthographicSize * cam.aspect;
        xmin = -camwidth + spriteWidth;
        xmax = camwidth - spriteWidth;
    }

    // Update is called once per frame
    void Update()
    {
        cameraBounds = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector2(cameraBounds, transform.position.y);
        
    }
}
