using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpwan : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject asteroid2;
    public GameObject asteroid3;
    public GameObject asteroid4;
    private int randomAsteroid;

    private float nextSpwan;
    private float spwanRate;
    
    void Start()
    {
        nextSpwan = 0f;
        spwanRate = 4f;
        
    }


    void Update()
    {
        spwan();
    }

    public void spwan()
    {
        randomAsteroid = Random.Range(1, 5);
        if (Time.time > nextSpwan)
        {

            switch (randomAsteroid)
            {
                case 1:
                    Instantiate(asteroid, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(asteroid2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(asteroid3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(asteroid4, transform.position, Quaternion.identity);
                    break;
            }
           
            nextSpwan = Time.time + spwanRate;
        }
        
    }
}
