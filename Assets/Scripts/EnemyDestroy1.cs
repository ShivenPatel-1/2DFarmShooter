using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy1 : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Score.scoreValue += 1;
            Destroy(this.gameObject);
            
        }
    }
}
