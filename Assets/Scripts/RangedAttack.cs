using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public float timer;
    private Transform _player;
    public Transform gunPos;
    private PlayerInput _playerInput => gameObject.GetComponent<PlayerInput>();

    void Start()
    {
        EnemyProjectilePool.Instance.AddObjects(10);
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;
       if(timer >= 2f)
        {
            Debug.Log("Attack");
            attack();
            timer = 0f;
        }
    }

    private void attack()
    {
        EnemyProjectile proj = EnemyProjectilePool.Instance.Get();
        proj.SetDirOfMoving(_player.position);
        proj.transform.position = gunPos.transform.position;
        proj.gameObject.SetActive(true);
        //shoot
    }
}
