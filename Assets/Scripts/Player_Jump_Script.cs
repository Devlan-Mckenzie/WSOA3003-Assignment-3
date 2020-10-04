using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump_Script : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0f,1f,0f) * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
