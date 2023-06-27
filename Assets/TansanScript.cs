using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TansanScript : MonoBehaviour
{
    public float kLifeTime=2.0f;
    private float lifeTime=0;
    private int WaterTime=0;
    public float MoveSpeed = 5.0f;
    public GameObject water;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, MoveSpeed*Time.deltaTime, 0);

        lifeTime += Time.deltaTime;
       

        if (kLifeTime <= lifeTime)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        WaterTime += 1;
        if (WaterTime % 3 == 0)
        {
           
           GameObject water1= Instantiate(water, gameObject.transform);
            water1.transform.parent = transform.parent;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bom"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
