using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] private float rotationSpeed = 100f;
    private Rigidbody rb;
    private Vector2 moveInput;
    private Vector2 lookInput;

    private void Awake() => rb = GetComponent<Rigidbody>();

    public void OnMove(InputAction.CallbackContext context) => moveInput = context.ReadValue<Vector2>();
    public void OnLook(InputAction.CallbackContext context) => lookInput = context.ReadValue<Vector2>();

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector3.forward * moveInput.y * moveSpeed);
        rb.AddRelativeTorque(new Vector3(lookInput.y, lookInput.x, 0) * rotationSpeed * Time.fixedDeltaTime);
    }
}