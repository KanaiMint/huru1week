using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position += new Vector3(0, DropSpeed*Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
           Destroy(this.gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
