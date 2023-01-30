using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket1 : MonoBehaviour
{
   
    private Rigidbody rb2;
    private float horizontalInput1;
    private float verticalInput1;
    private float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      

        //Player 2 controls
      float horizontalInput1 = Input.GetAxis("Horizontal1");
      float verticalInput1 = Input.GetAxis("Vertical1");
      Vector3 hareket1 = new Vector3(horizontalInput1, 0.0f, verticalInput1);
      rb2.AddForce(hareket1*speed);

    }

    
}
