using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public GameObject deathEff;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(deathEff, position: this.transform.position, Quaternion.identity);
        collision.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
