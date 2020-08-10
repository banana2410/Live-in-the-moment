using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _buttonInput;
    private bool _hasJumped;
    public float ButtonInput { get { return _buttonInput; } }
    public bool HasJumped { get { return _hasJumped; } }

    void Update()
    {
        _buttonInput = Input.GetAxisRaw("Horizontal");
    }

    public bool NeedToJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }
    public bool NeedToAttack()
    {
        if (Input.GetKeyDown(KeyCode.K))
            return true;
        else
            return false;
    }

}
