using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public InputActionReference inputAction;
    public float playerAcceleration;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        var input = inputAction.action.ReadValue<Vector2>();
        input.y = 0f;
        playerRigidbody.AddForce(input * playerAcceleration, ForceMode.Acceleration);
    }
}
