using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDeath : MonoBehaviour
{
    public GameObject objectToFall;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        objectToFall.SetActive(true);
        gameObject.SetActive(false);

    }


}
