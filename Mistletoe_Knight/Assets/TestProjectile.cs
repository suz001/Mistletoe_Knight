using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.tag != "Player")
        {
            if (collision.GetComponent<Enemy_Receive_Damane>() != null)
            {
         
                collision.GetComponent<Enemy_Receive_Damane>().DealDamage(damage);
            }
            
          
            Destroy(gameObject);
        }

       
    }
}