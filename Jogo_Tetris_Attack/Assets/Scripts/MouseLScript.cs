using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLScript : MonoBehaviour
{
    public GameObject bloco;
    public Vector2 blocoposition;
    public float horizontal, vertical;
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
        if (Input.GetButtonDown("Fire2"))
        {
            bloco.transform.position = GameObject.Find("mouseR").GetComponent<MouseRScript>().blocoposition; //mudando o bloco de lugar.
            if (bloco.tag == GameObject.Find("mouseR").GetComponent<MouseRScript>().bloco.tag)
            {
                Destroy(bloco);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject; //salvando o bloco que desejo modificar.
            blocoposition = bloco.transform.position; //salvando a posição do bloco.
            print(bloco.tag + "L");
        }
    }
}
