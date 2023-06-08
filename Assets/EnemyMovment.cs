using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    private void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(distance > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
