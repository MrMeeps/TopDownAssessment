using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 2.0f;
    public float pasteSpeed = 1.5f;
    public float pastethatDistance = 3.0f;
    public float chaseTriggerDistance = 5.0f;
    public Vector2 paceDirection;
    Vector3 startPosition;
    bool safeSpot = true;
    //safespot = home
     // pastethatdistance = pacedistance, pastespeed = pacespeed, paste = pace
    
    // Start is called before the first frame update
    // Today is the day
    // The bees knees
    // "would you like a cup of tea" 
    // "yes i do" 
    //"take the tea"
    // "no"
    void Start()
    {
        startPosition = transform.position;

    }
    //if one dares to read this you have now just wasted a couple seconds of your life
    //Happy birthday to the one's that is your birthday and if not happy late/ early birthday
    // These are little notes that I hope that make you smile when you read this.
    // Update is called once per frame
    void Update()
    {
        Vector2 chasethatDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if(chasethatDirection.magnitude < chaseTriggerDistance)
        {
            Chase();
        }else if (!safeSpot)
        {
            GoHome();
        }
        else
        {
            Paste();
        }
    }
    void Chase()
    {
        safeSpot = false;
        Vector2 chasethatDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        chasethatDirection.Normalize();
        transform.up = chasethatDirection;
        GetComponent<Rigidbody2D>().velocity = chasethatDirection * chaseSpeed;
        

    }
    void GoHome()
    {
        Vector2 homeDirection =  new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if(homeDirection.magnitude < 0.2f)
        {
            transform.position = startPosition;
            safeSpot = true;
        }
        else
        {
            homeDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = homeDirection * pasteSpeed;
            transform.up = homeDirection;
        }
    }
    void Paste()
        //paste means pace 
       
    {
        Vector3 displacement = transform.position - startPosition;
        if(displacement.magnitude >= pastethatDistance)
        {
            paceDirection = -displacement;
            
        }
        paceDirection.Normalize();
        transform.up = paceDirection;
        GetComponent<Rigidbody2D>().velocity = paceDirection * pasteSpeed;
    }
}
