using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);   
        }

        Destroy(this.gameObject);
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Physics.IgnoreCollision(Bullet1.collider, collider);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Score.scoreValue += 1;
            Destroy(collision.gameObject);
        }

        Destroy(this.gameObject);
    }
}
*/