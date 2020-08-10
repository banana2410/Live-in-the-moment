using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachinePiecePickupable : Pickupable
{
    public override void OnPickup()
    {
        gameObject.SetActive(false);
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}
