using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControlls : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    public GameObject bullet;
    public Rigidbody2D rb;

    void Start()
    {
        speed = 150f;
        forwardSpeed = 5f;
    }

   
    void Update()
    {
        rotateShip();
        //movement();
        shoot();
    }

    public void rotateShip()
    {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
    }

    /*public void movement()
    {
        float x;
        float y;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Vector2 force = new Vector2(x,y);
            rb.AddForce(force);
        }
    }
    */
    public void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);
            Instantiate(bullet, transform.position + offset, transform.rotation);
        }
    }

}
