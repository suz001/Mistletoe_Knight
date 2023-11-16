using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Receive_Damane : MonoBehaviour
{

    public float health;
    public float maxHealth;

    public GameObject lootDrop;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        health = health - damage;
        CheckDeath();
    }
    public void healCharacter(float heal)
    {
        health += health;
        CheckOverheal();
    }


    private void CheckOverheal()
        {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    private void CheckDeath()
        {
        if (health <= 0 )
        {
            Destroy(gameObject);
            Instantiate(lootDrop, transform.position, Quaternion.identity);
        }
    }

}
