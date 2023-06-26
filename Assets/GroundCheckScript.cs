using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{
    public bool isGrounded;  // �ڒn��Ԃ�\���t���O

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
      
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Nojump"))
    //    {
    //        isGrounded = false;
    //    }
    //}
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void Update()
    {
        //isGrounded = false;
    }
}
