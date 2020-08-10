using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    float xPos;
    public float ParallaxEffect;
    public float EffectSpeed;


    private void Start()
    {
        xPos = transform.position.x;
    }


    private void FixedUpdate()
    {
        float dist = (Camera.main.transform.position.x + ParallaxEffect);
        transform.position = Vector3.Lerp(transform.position, new Vector3(dist + xPos, transform.position.y, transform.position.z), Time.fixedDeltaTime * EffectSpeed);
    }

}
