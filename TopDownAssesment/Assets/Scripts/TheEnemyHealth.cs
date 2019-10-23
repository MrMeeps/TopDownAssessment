using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemyHealth : MonoBehaviour
{
    public int potatosFeeeed = 11;
    public GameObject prefab;

    // Start is called before the first frame update
    private void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GoodFly" )
        {
            potatosFeeeed--;
            if(potatosFeeeed < 1)
            {

                Destroy(gameObject);
                GameObject healthPlus = Instantiate(prefab);
            }

        }
    }
}
