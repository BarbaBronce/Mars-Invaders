using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserController : MonoBehaviour
{

    public float speed  =10f ;
    public Rigidbody2D myrb;
   

    // Start is called before the first frame update
    void Start()
    {
        myrb.velocity = transform.up * speed ;
     
    }

    // Update is called once per frame
  
    private void OnTriggerEnter2D(Collider2D other)

    {

        
        if(other.tag == "Enemy")
        {

            Text.FindObjectOfType<Text>().GetComponent<Score>().score += 10.0f;

            Destroy(this.gameObject);
        }

        if(other.tag == "Boundries")
        {
            Destroy(this.gameObject);
        }
      
    }


}
