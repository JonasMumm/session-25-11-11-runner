using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float waitSeconds;
    public float spawnRadius;

    public void Awake()
    {
        StartCoroutine(KeepSpawning());
    }

    IEnumerator KeepSpawning()
    {
        while (true)
        {
            var newObstacle = Instantiate(obstaclePrefab);
            var position = gameObject.transform.position;
            position.x += Random.Range(-spawnRadius, spawnRadius);
            newObstacle.transform.position = position;

            yield return new WaitForSeconds(waitSeconds);
        }
    }
}
