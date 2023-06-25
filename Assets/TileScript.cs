using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 衝突したオブジェクトがプレイヤーか判定
        if (collision.CompareTag("Bom"))
        {
            // タイルを削除する
           // collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Debug.Log("awdadadawd");
        }
    }
}
