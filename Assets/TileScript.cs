using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileScript : MonoBehaviour
{
    public TileBase tilegray;
    public Tilemap tilemap;
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

            //Vector3 hitpos = collision.transform.position;
            //Vector3Int grid = tilemap.WorldToCell(hitpos);
            //if (tilemap.HasTile(grid))
            //{
            //    tilemap.SetTile(grid, tilegray);
            //}


            // �^�C�����폜����
           // collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            Debug.Log("awdadadawd");
        }
    }
}
