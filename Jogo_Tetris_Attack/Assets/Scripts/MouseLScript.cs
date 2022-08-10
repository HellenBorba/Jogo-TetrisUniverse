using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLScript : MonoBehaviour
{
    public GameObject bloco;
    public Vector2 blocoposition;

    private float horizontal, vertical, maxX, minX, minY, maxY;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    { 
        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal >= 0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 1.15f, transform.position.y, transform.position.z);
        }
        else if (horizontal <= -0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x - 1.15f, transform.position.y, transform.position.z);
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        vertical = Input.GetAxisRaw("Vertical");
        if (vertical >= 0.9f && Input.GetButtonDown("Vertical"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
        }
        else if (vertical <= -0.9f && Input.GetButtonDown("Vertical"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        minX = -2.3f;
        maxX = 1.15f;

        minY = -8.19f;
        maxY = 3.31f;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX),
                                        Mathf.Clamp(transform.position.y, minY, maxY));
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject; //salvando o bloco que desejo modificar.
            blocoposition = bloco.transform.position; //salvando a posição do bloco.
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
