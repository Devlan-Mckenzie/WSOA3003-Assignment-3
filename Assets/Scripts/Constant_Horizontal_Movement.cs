using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant_Horizontal_Movement : MonoBehaviour
{
    public float speed_Mulitplier = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(1f, 0, 0) * speed_Mulitplier;
    }
}
