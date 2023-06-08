using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject HealthPickupPreFab;

    [SerializeField]
    private float HealthInterval = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnHealthPickup(HealthInterval, HealthPickupPreFab));
    }

    private IEnumerator spawnHealthPickup(float interval,GameObject HealthPickup)
    {
        yield return new WaitForSeconds(interval);
        GameObject newHealth = Instantiate(HealthPickup, new Vector3(Random.Range(-210f, -205), Random.Range(50f, 40f), 0), Quaternion.identity);
        StartCoroutine(spawnHealthPickup(interval, HealthPickup));
    }
}