using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float numDegreesPerSecond;
    public float speed = (float) 0.1;
    /*
     * we'd like game play to look similar across different machines, even if the machines have different speeds.
     * How can we do this?
     * We CAN'T just use hard-coded constants like 0.001 when we move or rotate!
     * Instead, we need to read the actual amount of time that has elapsed between frames.
     * Unity provides a variable called Time.deltaTime = #seconds since previous frame update.

    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0, 0, (float)0.5); // we must type cast 0.5 to float, since default is type double.
        // transform.Translate(0, (float) 0.001, 0);
        // Saw we want to rotate by 7 degrees per second.
        float numSecondsElapsed = Time.deltaTime;
        float amountToMove = numSecondsElapsed * speed;
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (float)0.1);
        }
        // float numDegreesToRotate = numSecondsElapsed * numDegreesPerSecond;
        // transform.Rotate(numDegreesToRotate, 0, 0);
    }
}
