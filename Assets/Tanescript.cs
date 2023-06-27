using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanescript : MonoBehaviour
{
    public GameObject seeds;
    private bool hasCollided = false; // ‰‰ñ‚ÌÕ“Ëƒtƒ‰ƒO
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -2*Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")&& !hasCollided)
        {
            hasCollided=true;
            Destroy(gameObject);
           GameObject seeds_= Instantiate(seeds);
           seeds_.transform.position = transform.position;
            seeds_.transform.parent = transform.parent;
        }
    }
}
