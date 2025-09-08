using UnityEngine;

public class PlayerController : MonoBehaviour
{   [Header("References")]
    [SerializeField] private Transform _orientationTransform;
    [Header("MovementSettings")]
    [SerializeField] private float _movementSpeed;
    private Rigidbody _PlayerRigidBody;
    private float _horizontalInput, _verticalInput;
    private Vector3 _movementDirection;

    private void Awake()
    {
        _PlayerRigidBody = GetComponent<Rigidbody>();
        _PlayerRigidBody.freezeRotation = true;
    }

    private void Update()
    {
        setInputs();
    }

    private void FixedUpdate()
    {
        SetPlayerMovement();
    }
    private void setInputs()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void SetPlayerMovement()
    {
        _movementDirection = _orientationTransform.forward * _verticalInput
            + _orientationTransform.right * _horizontalInput;
        _PlayerRigidBody.AddForce(_movementDirection * _movementSpeed, ForceMode.Force);
    }

}
