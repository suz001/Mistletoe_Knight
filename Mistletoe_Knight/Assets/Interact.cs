using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{

    public int gemNeeded;

    void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.tag == "Player")&& (Input.GetKeyDown(KeyCode.F)))
        {
                gemNeeded = gemNeeded - 10;
           // Debug.Log("Yes");
                PlayerStats.playerStats.SubGems(this);

           
                //gemNeeded = gemNeeded - 10;

                if (gemNeeded==0)
            {
                SceneManager.LoadScene(2);
            }

        }


    }
}
