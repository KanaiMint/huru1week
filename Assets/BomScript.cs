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
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        // ���������I�u�W�F�N�g���^�C���ł���΁A�^�C������
    //        Tile tile = collision.gameObject.GetComponent<Tile>();
    //        if (tile != null)
    //        {
    //            Destroy(tile);
    //        }

    //        // �e���폜����
    //        Destroy(gameObject);
    //    }
    //}


    //private void OnCollisionEnter2D(Collision2D ot)
    //{
    //    Vector3 hitPos = Vector3.zero;
    //    foreach (ContactPoint2D point in ot.contacts)
    //    {
    //        hitPos = point.point;
    //    }

    //    BoundsInt.PositionEnumerator position = ot.gameObject.GetComponent<Tilemap>().cellBounds.allPositionsWithin;
    //    var allPosition = new List<Vector3>();
    //    //��ԋ߂��ꏊ��ۑ��������̂ŕϐ���錾
    //    int minPositionNum = 0;

    //    foreach (var variable in position)
    //    {
    //        if (ot.gameObject.GetComponent<Tilemap>().GetTile(variable) != null)
    //        {
    //            allPosition.Add(variable);
    //        }
    //    }

    //    //for���ŒT������B�ł���������0����Ă邩��1����X�^�[�g
    //    for (int i = 1; i < allPosition.Count; i++)
    //    {
    //        //���ꂼ��̂��������ꏊ����̑傫�����擾�A�ŏ����X�V������minPositionNum���X�V����
    //        if ((hitPos - allPosition[i]).magnitude <
    //            (hitPos - allPosition[minPositionNum]).magnitude)
    //        {
    //            minPositionNum = i;
    //        }
    //    }

    //    //�ŏI�I�Ȉʒu����U�i�[�����BRoundToInt�͎l�̌ܓ��Ƃ̂��Ƃł�
    //    Vector3Int finalPosition = Vector3Int.RoundToInt(allPosition[minPositionNum]);


    //    TileBase tiletmp = ot.gameObject.GetComponent<Tilemap>().GetTile(finalPosition);

    //    if (tiletmp != null)
    //    {
    //        Tilemap map = ot.gameObject.GetComponent<Tilemap>();
    //        TilemapCollider2D tileCol = ot.gameObject.GetComponent<TilemapCollider2D>();

    //        map.SetTile(finalPosition, null);
    //        tileCol.enabled = false;
    //        tileCol.enabled = true;
    //    }
    //}
}
