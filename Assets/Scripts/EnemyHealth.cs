using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, ICanTakeDamage
{
    private int _healthPoints = 1;
    public GameObject deathEffect;

    public void RemoveHealthPoints()
    {
        _healthPoints--;
        if (_healthPoints <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Instantiate(deathEffect, position: gameObject.transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }

    public void TakeDamage()
    {
        RemoveHealthPoints();
    }
}
