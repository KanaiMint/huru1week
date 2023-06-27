using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsScript : MonoBehaviour
{
    public float GrowthLevel = 0;
    public GameObject ninjin;
    public bool isground = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GrowthLevel >= 50)
        {
          GameObject ninjintmp= Instantiate(ninjin);
            ninjintmp.transform.position= transform.position;
            ninjintmp.transform.parent=transform.parent; 
            Destroy(gameObject);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Water"))
        {
            GrowthLevel += 2;
        }
        if (collision.CompareTag("Bom"))
        {
            Destroy(gameObject);
        }        
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Ground"))
    //    {
    //        isground= false;
    //    }
    //}

}
