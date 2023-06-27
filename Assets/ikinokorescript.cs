using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ikinokorescript : MonoBehaviour
{
    private Vector3 faksepos;
    // Start is called before the first frame update
    void Start()
    {
        faksepos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position += new Vector3((-4.5f*Time.deltaTime), 0,0);
    }

   
}
