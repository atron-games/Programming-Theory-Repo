using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitten : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        StartSequence();
    }

    // Update is called once per frame
    void Update()
    {
        PassInputs();
    }

    public override void Move(float v, float h)
    {
        float speed = 6;
        float rotationSpeed = 60;

        transform.Translate(Vector3.forward * Time.deltaTime * speed * v);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * h);
    }

    public override void Jump()
    {
        float jumpForce = 4;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
