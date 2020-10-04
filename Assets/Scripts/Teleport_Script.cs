using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Script : MonoBehaviour
{
    private Rigidbody rb;
    public float teleport_Distance = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.position = new Vector3(rb.position.x - teleport_Distance, rb.position.y, rb.position.z);
        }
    }
}
