using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class New_input : MonoBehaviour
{
    [SerializeField] InputActionReference moveAction;

    void OnEnable() => moveAction.action.Enable();
    void OnDisable() => moveAction.action.Disable();
    public Rigidbody2D rb;
    [Header("Jump Value")]
    public float Jumpforce = 5f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 move = moveAction.action.ReadValue<Vector2>();
        rb.linearVelocity = new Vector2(move.x * 5, rb.linearVelocityY);
    }

    public void Jump()
    {
        rb.AddForce(transform.up * Jumpforce, ForceMode2D.Impulse);
    }
}
