using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Modified from Chris' Tutorials on Youtube https://www.youtube.com/watch?v=12AbcoLrYKM
public class keyPickup : MonoBehaviour
{
    //public GameItem item;     needs to be set up!

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.GetComponent<PlayerMovement>();

        if(player != null)
        {
            player.haveKey = true;
            //  player.inventory.add(item);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
