using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
 
    //Transform mytransform;
    public float speed = 10f;
    public GameObject Laser;

    private void Start()
    {
      //  mytransform = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        PlayerAttack();
    }
    void FixedUpdate()
    {
        PlayerMovement();

    }
    void PlayerMovement()
    {
        //Move player
        float timespeed = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           
            transform.position = new Vector3(transform.position.x - timespeed, transform.position.y, transform.position.z);

        }else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
           
            transform.position = new Vector3(transform.position.x + timespeed, transform.position.y, transform.position.z);

        }

    }

    void PlayerAttack()
    {
       
        
        if (Input.GetKeyDown(KeyCode.Space) && GameObject.FindGameObjectWithTag("Bullet") == false)
        {
            Vector3 lasertransform = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);

            Instantiate(Laser, lasertransform, transform.rotation);
           // Debug.Log("Shoted");
        }
    }
   
}
