using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public InputActionReference inputAction;
    public float playerAcceleration;
    public AudioSource hitAudio;
    
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            hitAudio.Play();
            SceneManager.LoadScene(0);
        }
    }
}
