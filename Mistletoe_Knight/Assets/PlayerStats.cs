using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    public GameObject player;
    public float health;
    public float maxHealth;

   // public Text healthText;
    public Slider healthSlider;
    public TextMeshProUGUI gemsValue;
    public TextMeshProUGUI gemsNeeded;


    public int gems;

    public int need;
    void Awake()
    {
        if(playerStats !=null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        
        DontDestroyOnLoad(this);
    }
    
    void Start()
    {
        health = maxHealth;
        healthSlider.value=1;
    }

    public void DealDamage(float damage)
    {
        health = health - damage;
        CheckDeath();
        healthSlider.value = CalculateHealthPercentage();
    }

    public void healCharacter(float heal)
    {
        health += health;
        CheckOverheal();
        healthSlider.value = CalculateHealthPercentage();
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
        if (health <= 0)
        {
            Destroy(player);
            SceneManager.LoadScene(3);
        }
    }

    float CalculateHealthPercentage()
    {


        return health / maxHealth;
    }

    public void AddGems(Currentpickup currency)
    {
        
         gems = gems + currency.pickupQuantity;
         gemsValue.text = "Gems: " + gems.ToString();
      
    }

    public void SubGems(Interact intactTree)
    {
            
            gems = gems - 10;
            
            gemsNeeded.text = "Need " + intactTree.gemNeeded.ToString() + " More Gems";
            gemsValue.text = "Gems: " + gems.ToString();

    }

}
