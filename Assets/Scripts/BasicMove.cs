using UnityEngine;

public class BasicMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;

    private float _horizontalInput;
    private float _verticalInput;

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.position += transform.forward * (_verticalInput * moveSpeed * Time.fixedDeltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, _horizontalInput * rotateSpeed * Time.fixedDeltaTime);
    }
    
    
}
