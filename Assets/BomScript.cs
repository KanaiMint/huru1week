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

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        // 当たったオブジェクトがタイルであれば、タイルを壊す
    //        Tile tile = collision.gameObject.GetComponent<Tile>();
    //        if (tile != null)
    //        {
    //            Destroy(tile);
    //        }

    //        // 弾を削除する
    //        Destroy(gameObject);
    //    }
    //}


    private void OnCollisionEnter2D(Collision2D ot)
    {
        Vector3 hitPos = Vector3.zero;
        foreach (ContactPoint2D point in ot.contacts)
        {
            hitPos = point.point;
        }

        BoundsInt.PositionEnumerator position = ot.gameObject.GetComponent<Tilemap>().cellBounds.allPositionsWithin;
        var allPosition = new List<Vector3>();
        //一番近い場所を保存したいので変数を宣言
        int minPositionNum = 0;

        foreach (var variable in position)
        {
            if (ot.gameObject.GetComponent<Tilemap>().GetTile(variable) != null)
            {
                allPosition.Add(variable);
            }
        }

        //for文で探査する。でも初期化で0入れてるから1からスタート
        for (int i = 1; i < allPosition.Count; i++)
        {
            //それぞれのあたった場所からの大きさを取得、最小を更新したらminPositionNumを更新する
            if ((hitPos - allPosition[i]).magnitude <
                (hitPos - allPosition[minPositionNum]).magnitude)
            {
                minPositionNum = i;
            }
        }

        //最終的な位置を一旦格納した。RoundToIntは四捨五入とのことです
        Vector3Int finalPosition = Vector3Int.RoundToInt(allPosition[minPositionNum]);


        TileBase tiletmp = ot.gameObject.GetComponent<Tilemap>().GetTile(finalPosition);

        if (tiletmp != null)
        {
            Tilemap map = ot.gameObject.GetComponent<Tilemap>();
            TilemapCollider2D tileCol = ot.gameObject.GetComponent<TilemapCollider2D>();

            map.SetTile(finalPosition, null);
            tileCol.enabled = false;
            tileCol.enabled = true;
        }
    }
}
