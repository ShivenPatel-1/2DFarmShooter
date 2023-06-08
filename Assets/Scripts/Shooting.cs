using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //damage, firerate, and the firerate delay (currently the same for all weapons, could change these later for each gun?)
    public int damage = 4;
    public float fireRate = 4;
    private float lastFired;
    
    public Transform firePoint;

    public Transform firePointShotgun;
    public Transform firePointShotgun2;

    public GameObject bulletPrefab;
    
    

    public float bulletForce = 20f;

    
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                //changes to A.R. Damage and firerate
                damage = 4;
                fireRate = 6;
                bulletForce = 7;

                lastFired = Time.time;
                Shoot();
            }
            
        }
        if (Input.GetButton("Fire2"))
        {
            if (Time.time - lastFired > 1 / fireRate)
            {
                //changes to shotgun damage and firerate 
                damage = 2;
                fireRate = 2;
                bulletForce = 4;

                lastFired = Time.time;
                Shoot();
                ShotgunShoot();
            }
        }
    }



    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    void ShotgunShoot()
    {
        GameObject bullet1 =  Instantiate(bulletPrefab, firePointShotgun.position, firePointShotgun.rotation);
        
        GameObject bullet2 = Instantiate(bulletPrefab, firePointShotgun2.position, firePointShotgun2.rotation);
        

        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();

        rb1.AddForce(firePointShotgun.up * bulletForce, ForceMode2D.Impulse);
        
        
        rb2.AddForce(firePointShotgun2.up * bulletForce, ForceMode2D.Impulse);
    }
/*
    void ShotgunShoot()
    {
        GameObject leftbullet  = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation - 30);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject rightbullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation + 30);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
*/
}
