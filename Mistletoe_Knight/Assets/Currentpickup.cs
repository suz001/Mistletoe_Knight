using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currentpickup : MonoBehaviour
{
   // public enum PickupObject{GEM};
    //public PickupObject currentObject;
    public int pickupQuantity;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerStats.playerStats.AddGems(this);
            Destroy(gameObject);
           
        }
    }
    }
