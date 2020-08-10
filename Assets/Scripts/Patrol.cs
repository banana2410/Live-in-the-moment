using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DirectionOfMoving { Left, Right }
public class Patrol : MonoBehaviour
{
    public LayerMask whatIsGround;
    public Transform groundCheckPos;
    public float speed = 2f;
    private DirectionOfMoving _dirOfMoving;

    // Start is called before the first frame update
    void Start()
    {
        _dirOfMoving = DirectionOfMoving.Left;
    }

    // Update is called once per frame
    void Update()
    {
        checkForGround();
        if (_dirOfMoving == DirectionOfMoving.Left)
        {
            move(_dirOfMoving);
        }
        else
        {
            move(_dirOfMoving);
        }

    }
    private void move(DirectionOfMoving dir)
    {
        if (dir == DirectionOfMoving.Left)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }

    private void checkForGround()
    {
        RaycastHit2D ray = Physics2D.Raycast(groundCheckPos.position, Vector2.down, 0.4f, layerMask: whatIsGround);
        if (ray.collider == null)
        {
            if (_dirOfMoving == DirectionOfMoving.Left)
            {
                rotateRight();
            }
            else
            {
                rotateLeft();
            }

        }
    }
    private void rotateLeft()
    {
        transform.Rotate(0f, 180f, 0f);
        _dirOfMoving = DirectionOfMoving.Right;
    }
    private void rotateRight()
    {
        transform.Rotate(0f, 180f, 0f);
        _dirOfMoving = DirectionOfMoving.Left;
    }
}
