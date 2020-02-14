using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMiddleBevaviour : MonoBehaviour
{
    public int maxHits;
    void Start()
    {
        maxHits = 3;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bullet")
        {
            maxHits -= 1;
            Destroy(collision.gameObject);
            if (maxHits <= 0)
            {
                Destroy(gameObject);
            }

        }
    }
}
