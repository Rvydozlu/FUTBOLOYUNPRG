using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeTakip : MonoBehaviour
{
    public Transform obje2;
    public Vector3 ofset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(obje2.position);
       transform.position = obje2.position;
    }
}
