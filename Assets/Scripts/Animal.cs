using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        StartSequence(); //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        PassInputs(); //ABSTRACTION
    }

    public void StartSequence()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    public void PassInputs()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Move(verticalInput, horizontalInput); //ABSTRACTION
        SetAnimation(verticalInput);          //ABSTRACTION

        if (Input.GetKeyDown(KeyCode.Space))
        { Jump(); }
    }

    public virtual void Move(float v, float h)
    {
        float speed = 10;
        float rotationSpeed = 60;
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * v);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * h);
    }

    public virtual void Jump()
    {
        float jumpForce = 5;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void SetAnimation(float v)
    {
        animator.SetFloat("forwardAnim", v);
    }

}
