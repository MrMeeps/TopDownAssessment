using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public int lives = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Healthr: " + health;
            if(health < 1) 
            {
                SceneManager.LoadScene("Lose");
                  
                //SceneManager.LoadScene("Lose");
            }
        }
        else if (collision.gameObject.tag == "healthPlus")
        {
            health++;
            if(health < 10)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
    
}
