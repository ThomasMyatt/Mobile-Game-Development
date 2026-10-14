using UnityEngine;
using UnityEngine.InputSystem;

public class New_input : MonoBehaviour
{
    [SerializeField] InputActionReference moveAction;

    void OnEnable() => moveAction.action.Enable();
    void OnDisable() => moveAction.action.Disable();
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveAction.action.ReadValue<Vector2>();
        rb.linearVelocity = new Vector2(move.x * 5, move.y * 5);

        
    }
}
