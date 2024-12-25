using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playerCamera;

    public float movementForce = 500f;
    public float jumpForce = 5f; // Kekuatan lompat
    public float mouseSensitivity = 100f;
    public float maxVerticalAngle = 80f;

    private float cameraRotationX = 0f;
    private bool isGrounded = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseX);

        cameraRotationX -= mouseY;
        cameraRotationX = Mathf.Clamp(cameraRotationX, -maxVerticalAngle, maxVerticalAngle);
        playerCamera.localRotation = Quaternion.Euler(cameraRotationX, 0f, 0f);
    }

    void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += transform.forward;
        }

        if (Input.GetKey("s"))
        {
            movement -= transform.forward;
        }

        if (Input.GetKey("d"))
        {
            movement += transform.right;
        }

        if (Input.GetKey("a"))
        {
            movement -= transform.right;
        }

        rb.AddForce(movement.normalized * movementForce * Time.deltaTime, ForceMode.VelocityChange);

        // Lompatan (Space)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}