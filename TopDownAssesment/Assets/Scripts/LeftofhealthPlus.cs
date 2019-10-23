﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftofhealthPlus : MonoBehaviour
{
    float timer = 0; 
    public float onTime = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0 && timer < onTime)
            Destroy(gameObject);
    }
}
