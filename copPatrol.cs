using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copPatrol : MonoBehaviour
{
    public float speed;             // AI Pathfinding tutorials by 
    private float waitTime;         // Blackthornprod on Youtube
    public float startWaitTime;
    //public float horizontal;
    Transform myTrans;
    public Transform[] moveSpots;
    private int randomSpot;
    public float prevX;             //Thank you Dan
    public float prevX2;

    public int g = 0;


    void Start()
    {
        myTrans = this.transform;
        //facingRight = true;
        prevX = this.transform.position.x;
        prevX2 = prevX;
        randomSpot = Random.Range(0, moveSpots.Length);
    }
    

    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                g = 0;
                prevX2 = prevX;
                prevX = this.transform.position.x;
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    public void FixedUpdate()
    {
      if(moveSpots[randomSpot].position.x < this.transform.position.x /*&& g == 0 */)
        {
           Vector3 copRotate = myTrans.eulerAngles;
           // if (prevX2 > moveSpots[randomSpot].position.x && prevX2 <= prevX)
           // {
           copRotate.y = 180;
           // }
           // g = 1;
           myTrans.eulerAngles = copRotate;
           // transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
            waitTime = startWaitTime;
        }
      else if (moveSpots[randomSpot].position.x > this.transform.position.x /*&& g == 0*/)
        {
            Vector3 copRotate = myTrans.eulerAngles;
            //if (prevX2 < moveSpots[randomSpot].position.x && prevX2 >= prevX)
            //{
                copRotate.y = 0;
            //}
           // g = 1;
            myTrans.eulerAngles = copRotate;
           // transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
            waitTime = startWaitTime;
        }
    }

  /*  public void FlipCop()   //Player Flipping tutorial by inScope Studios on Youtube:https://www.youtube.com/watch?v=FHQyPgccD4M 
    {
       if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            
        }
    } */
}
    
