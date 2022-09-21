using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SnakeMove : MonoBehaviour
{
    [SerializeField] private float _sideSpeed;
    [SerializeField] private float _forwardSpeed;
    public float forwardSpeed => _forwardSpeed;

    private float oldSideSpeed;
    private float oldForwardSpeed;

    private Rigidbody _rb;
    private SnakeInput snakeInput;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        snakeInput = GetComponent<SnakeInput>();
        SaveSpeed();
    }
    private void FixedUpdate()
    {
        MoveByMouse(snakeInput.Direction());
    }
    private void MoveByMouse(Vector3 direction)
    {
        _rb.velocity = new Vector3(direction.x * _sideSpeed, 0, _forwardSpeed);
    }
    public void SnakeStop()
    {
        _sideSpeed = 0;
        _forwardSpeed = 0;
    }
    public void SnakeMoveAgain()
    {
        _sideSpeed = oldSideSpeed;
        _forwardSpeed = oldForwardSpeed;
    }
    private void SaveSpeed()
    {
        oldSideSpeed = _sideSpeed;
        oldForwardSpeed = _forwardSpeed;
    }
}
