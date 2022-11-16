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

}
