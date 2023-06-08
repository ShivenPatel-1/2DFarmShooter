using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour

{
    private Rigidbody2D rb;
    int coins = 0;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.gameObject.CompareTag("Coins"))
        {
            Destroy(Coin.gameObject);
            coins += 1;


        }
    }



}
