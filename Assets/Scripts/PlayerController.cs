using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementAcceleration;
    public InputActionReference movementInputActionReference;
    public Rigidbody myRigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var input = movementInputActionReference.action.ReadValue<Vector2>();
        var xAcceleration = input.x * movementAcceleration;
        myRigidbody.AddForce(new Vector3(xAcceleration, 0f, 0f));
    }
}
