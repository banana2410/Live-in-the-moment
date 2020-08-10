using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private float _timer;
    Vector2 dirOfMoving;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        transform.Translate(Vector2.left * Time.deltaTime * 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyProjectilePool.Instance.ReturnToPool(this);
    }
    public void SetDirOfMoving(Vector2 dir)
    {
        dirOfMoving = dir;
    }
}
