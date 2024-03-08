using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Press key A");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Press key S");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Press key D");
        }
    }
}
