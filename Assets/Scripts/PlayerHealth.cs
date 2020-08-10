using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOverScreen;
    
    public void die()
    {
        gameObject.SetActive(true);
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer  == LayerMask.NameToLayer("Enemy"))
        {
            die();
        }
    }
}
