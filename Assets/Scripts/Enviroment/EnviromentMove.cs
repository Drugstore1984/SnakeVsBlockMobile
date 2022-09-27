using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnviromentMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _xMin,_xMax;
    [SerializeField] private bool _isMovingRight = true;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Move();
        Flip();
    }
    private void Move()
    {
        if (_isMovingRight)
        {
            rb.velocity = new Vector3(_speed, 0, 0);
        }
        else
        {
            rb.velocity = new Vector3(_speed * -1, 0, 0);
        }
    }
    private void Flip()
    {
        if (transform.position.x <= _xMin)
        {
            _isMovingRight = true;
        }
        else if(transform.position.x >= _xMax)
        {
            _isMovingRight = false;
        }
    }
}
