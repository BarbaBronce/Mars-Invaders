using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyArmyMovement : MonoBehaviour
{

    Transform mytransform;
    public float speed = 10f;
    float direction = 1f;
    float advancemovement = 0.25f;

    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    public Collider2D mycollider2D;

    private Transform myRespawnPoint;

    private void Start()
    {
        mytransform = gameObject.GetComponent<Transform>();
        myRespawnPoint = gameObject.GetComponent<Transform>();
       
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = mycollider2D.bounds.size.x ;
        objectHeight = mycollider2D.bounds.size.y / 2;
    }

    void FixedUpdate()
    {
        LavaEnemyController();
    }

    void LavaEnemyController()
    {
        // var for speed in time
        float timespeed;
       
        //Enemy Controller
        if (mytransform.position.x <= screenBounds.x +0.7f || mytransform.position.x >= -screenBounds.x - objectWidth)
        {
             Debug.Log(screenBounds.x);
            //change direction
            direction = -1f * direction;
            //move forward
            transform.Translate(0, -advancemovement,0);
            //increase movement forward
            advancemovement+= 0.025f;
        }
        // update speed with new direcction 
        timespeed = speed * Time.deltaTime * direction;
        // move enemy
        transform.position = new Vector3(transform.position.x - (timespeed), transform.position.y, transform.position.z);
        
      
       
    }
    
}
