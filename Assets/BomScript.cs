using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BomScript : MonoBehaviour
{
    public float MoveSpeed = 3.0f;
    private Animator m_Animator;
    private bool canmove = true;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            transform.position += new Vector3(0, -MoveSpeed * Time.deltaTime, 0);

        }
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground")) 
        {
            canmove = false;
            m_Animator.SetTrigger("isExploded");
            Destroy(collision.gameObject);
           // Destroy(gameObject);
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


    //private void OnCollisionEnter2D(Collision2D ot)
    //{
    //    Vector3 hitPos = Vector3.zero;
    //    foreach (ContactPoint2D point in ot.contacts)
    //    {
    //        hitPos = point.point;
    //    }

    //    BoundsInt.PositionEnumerator position = ot.gameObject.GetComponent<Tilemap>().cellBounds.allPositionsWithin;
    //    var allPosition = new List<Vector3>();
    //    //一番近い場所を保存したいので変数を宣言
    //    int minPositionNum = 0;

    //    foreach (var variable in position)
    //    {
    //        if (ot.gameObject.GetComponent<Tilemap>().GetTile(variable) != null)
    //        {
    //            allPosition.Add(variable);
    //        }
    //    }

    //    //for文で探査する。でも初期化で0入れてるから1からスタート
    //    for (int i = 1; i < allPosition.Count; i++)
    //    {
    //        //それぞれのあたった場所からの大きさを取得、最小を更新したらminPositionNumを更新する
    //        if ((hitPos - allPosition[i]).magnitude <
    //            (hitPos - allPosition[minPositionNum]).magnitude)
    //        {
    //            minPositionNum = i;
    //        }
    //    }

    //    //最終的な位置を一旦格納した。RoundToIntは四捨五入とのことです
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
