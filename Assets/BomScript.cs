using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -3.0f * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")) 
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // 当たったオブジェクトがタイルであれば、タイルを壊す
            Tile tile = collision.gameObject.GetComponent<Tile>();
            if (tile != null)
            {
                Destroy(tile);
            }

            // 弾を削除する
            Destroy(gameObject);
        }
    }
}
