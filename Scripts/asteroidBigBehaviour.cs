using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class asteroidBigBehaviour : MonoBehaviour
{
    public GameObject asteroidMiddle;
    public Text score;
    public int currentScore;
    public int asteroidScore;
    private int maxHits;
    public int totalScore;
    void Start()
    {
        asteroidScore = 15;
        maxHits = 5;
             
        
    }

    void Update()
    {
        currentScore = int.Parse(score.text);
       
        score.text = totalScore.ToString();
        
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
                    totalScore += currentScore;
                    
                }              
                
                if(maxHits == 2)
                {
                    Instantiate(asteroidMiddle, transform.position, Quaternion.identity);
                    Instantiate(asteroidMiddle, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }
            }
        }
}
