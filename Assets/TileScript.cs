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
        // �Փ˂����I�u�W�F�N�g���v���C���[������
        if (collision.CompareTag("Bom"))
        {
            // �^�C�����폜����
           // collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Debug.Log("awdadadawd");
        }
    }
}
