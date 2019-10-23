using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootThePlayer : MonoBehaviour
{
    public Transform player;
    public float speednessbulletheckyeah = 10.0f;
    public float thelivingmomentsofthebullet;
    public float pausenessofthebullet = 1.0f;
    public GameObject prefab;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        timer += Time.deltaTime;
        if (timer > pausenessofthebullet)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
            

     
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * speednessbulletheckyeah;
            Destroy(bullet, thelivingmomentsofthebullet);
             
            
        }
    }
}
