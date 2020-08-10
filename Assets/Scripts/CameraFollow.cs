using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _playerTransform;

    private void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void LateUpdate()
    {
        
    }
    private void FixedUpdate()
    {
        followPlayer();

    }
    private void followPlayer()
    {
       // transform.position = new Vector3(_playerTransform.transform.position.x + 5f, Mathf.Clamp(_playerTransform.transform.position.y, -1f, 1.7f), transform.position.z);
        transform.position = Vector3.Lerp(transform.position, new Vector3(_playerTransform.transform.position.x + 3f, Mathf.Clamp(_playerTransform.transform.position.y, -2.4f, 3.3f), transform.position.z), Time.fixedDeltaTime*6f);
    }
}
