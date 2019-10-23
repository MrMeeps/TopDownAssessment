using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownRotateMovement : MonoBehaviour
{
    public float SpeedtheNeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositon = Input.mousePosition;
        mousePositon = Camera.main.ScreenToWorldPoint(mousePositon);
        mousePositon.z = transform.position.z;
        transform.up = mousePositon - transform.position;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 moveDir = y * transform.up + x * transform.right;
        moveDir.Normalize();
        GetComponent<Rigidbody2D>().velocity = moveDir * SpeedtheNeed;



    }
}
