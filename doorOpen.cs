using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorOpen : MonoBehaviour
{


    public GameObject doorLeft;
    public GameObject doorRight;
       
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.GetComponent<PlayerMovement>();

        if (player.haveKey == true)
        {
            Destroy(gameObject);
            doorLeft.transform.position += new Vector3(-.74f, 0, 0);
            doorRight.transform.position += new Vector3(.74f, 0, 0);
            //door.transform.position = Vector3(door.transform.position, Time.deltaTime * speed);

        }
        else
        {
            Debug.Log("The door will not open");
        }
            
        
    }

   
}

