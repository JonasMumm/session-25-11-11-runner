using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector3 speed;
    public float secondsToLive;

    void Awake()
    {
        Destroy(gameObject, secondsToLive);
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}
