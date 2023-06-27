using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float JumpPower = 100;
    private Rigidbody2D rb;
    public bool IsJump = false;
    public float HungerLevel = 100;
    public float MaxHungerLevel = 100;
    public GroundCheckScript GroundCheck; // Ground Check オブジェクトへの参照
    public GameObject tansan;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        HungerLevel-=Time.deltaTime*2;
        HungerLevel=Mathf.Clamp(HungerLevel,0,MaxHungerLevel);
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-MoveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck.isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpPower);
           GameObject Tansan = Instantiate(tansan,transform.position,Quaternion.identity);
            Tansan.transform.parent = transform.parent;
            GroundCheck.isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            HungerLevel -= 3;
        }

        if (collision.CompareTag("Ninjin"))
        {
            HungerLevel += 20;
            Destroy(collision.gameObject);
        }
    }
}
