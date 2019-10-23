using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerLeft = 30.0f;
    public Text timer;
    
    // Start is called before the first frame update
  private void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        timerLeft -= Time.deltaTime;
        
        if(timerLeft < 0)
        {
            SceneManager.LoadScene("Lose");
        }
        timer.text = "Timer: " + timerLeft;
    }
}
