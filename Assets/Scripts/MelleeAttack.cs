using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelleeAttack : MonoBehaviour
{
    public LayerMask enemiesLayer;
    public float attackRange;
    public Transform attPos;
    private PlayerInput _playerInput;
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(_playerInput.NeedToAttack())
        {
            Attack();
        }
     
    }
    public void Attack()
    {
        Collider2D[] damage = Physics2D.OverlapCircleAll(attPos.position, attackRange, enemiesLayer);

        for (int i = 0; i < damage.Length; i++)
        {
            ICanTakeDamage objToTakeDamage = damage[i].GetComponent<ICanTakeDamage>();
            if(objToTakeDamage != null)
            {
                objToTakeDamage.TakeDamage();
            }
        }
    }
}
