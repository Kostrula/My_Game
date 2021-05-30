﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]
public class InventoryItem : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemImage;
    public int numberHeld;
    public bool usable;
    public bool unique;
    public UnityEvent thisEnvent;

    public void Use()
    {
        thisEnvent.Invoke();
    }

    public void DecreaseAmount(int amountToDecrease)
    {
        numberHeld -= amountToDecrease;
        if (numberHeld < 0)
        {
            numberHeld = 0;
        }
    }
}
