﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartContainer : PowerUp
{
    public FloatValue heartContainers;
    public FloatValue playerHealth;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && !other.isTrigger)
        {
            
            heartContainers.RunTimeValue += 1;
            playerHealth.RunTimeValue = heartContainers.RunTimeValue * 2;
            powerUpSignal.Raise();
            
            Destroy(this.gameObject);
        }
    }
}
