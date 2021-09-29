using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float moveInput;
    private float moveInput2;

    public Transform cam;
    public float mouseSensitivity;
    private float cameraPitch = 0f;
    bool lockCursor = true;


    public float turnSmoothTime = 0f;
    public float turnSmoothVelocity;



    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        if(lockCursor){
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void FixedUpdate() {

    }

    // Update is called once per frame
    void Update()
    {
            moveInput = Input.GetAxisRaw("Horizontal");
            moveInput2 = Input.GetAxisRaw("Vertical");
            Vector2 direction = new Vector2(moveInput, moveInput2).normalized;
            Vector3 move = (transform.forward * direction.y + transform.right * direction.x) * speed;
            rb.velocity = (move * Time.deltaTime);


        //CAMERA ROTATE
            Vector3 mouseDirection = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
            transform.Rotate(Vector3.up * mouseDirection.x * mouseSensitivity);
            cameraPitch -= mouseDirection.y * mouseSensitivity;
            cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
            cam.localEulerAngles = Vector3.right * cameraPitch;
            
        
        //  if (direction.magnitude >= 0.1f) {
        //         float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        //         //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        //         //transform.rotation= Quaternion.Euler(0f,angle,0f);

        //         Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        //         rb.velocity = (moveDir * speed);
        //  }
    }

}
