using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Toggle_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.gravity = -Physics.gravity;
        }
    }
}
