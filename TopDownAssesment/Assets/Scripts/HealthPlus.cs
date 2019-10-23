using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlus : MonoBehaviour
{
    public int healthPlus = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "healthPlus")
        {
            healthPlus++;
            Destroy(collision.gameObject); 

        }
    }


}
