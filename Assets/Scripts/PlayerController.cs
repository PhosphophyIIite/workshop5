using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private float movementX;
    private float movementY;
    public float jumpForce;
    public LayerMask ground;
    public float rotationSpeed;
    private Vector3 rotation;
    private float rotationDirection;
    private bool grounded;
    private RaycastHit groundHit;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    public void FixedUpdate()
    {
        //move player forwards
        Vector3 movement = new Vector3(movementX, 0.0f, movementY) * Time.deltaTime * moveSpeed;

        Vector3 direction = (transform.position - (transform.position + movement)).normalized;

        //move player forwards or backwards when a/s are pressed
        rb.MovePosition(transform.position + direction);

        //rotate player with force when a/d is pressed
        rb.AddTorque(rotation * Time.deltaTime * rotationSpeed);
    }

    //when rotate input is entered (a, s, left, right)
    public void OnRotate(InputValue rotationValue)
    {
        //get rotation value from input (-1 / 0 / 1)
        rotationDirection = rotationValue.Get<float>();
        rotation = transform.up * rotationDirection;
        //Debug.Log(rotation);
    }

    //when player presses space add force upwards
    public void OnJump()
    {
        //check if grounded
        CheckGround();

        //when grounded jump
        if (grounded)
        {
            rb.AddForce(0.0f, jumpForce, 0.0f);
        }
    }

    public void CheckGround()
    {
        Debug.Log("checkground");
        ////send raycast below player with variables: start, direction, distance, hit return, layermask
        Ray groundRay = new Ray(rb.position, Vector3.down);
        grounded = Physics.Raycast(groundRay, out groundHit, 2f, ground);

        Debug.DrawRay(rb.position, Vector3.down, Color.white, 1f);
    }
}
