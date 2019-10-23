using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
   
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletslivingmoments;
    public float shootneedsamentalbreak = 1.0f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && timer > shootneedsamentalbreak)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log(mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log(mousePosition);
            Vector2 shootDir = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletslivingmoments);



        }
    }
}
