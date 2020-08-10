using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickupable : MonoBehaviour
{
    public GameObject pickupEffect;
    private void Start()
    {

    }
    public virtual void OnPickup() { }
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(pickupEffect, position: this.transform.position, Quaternion.identity);
        OnPickup();
    }
}
