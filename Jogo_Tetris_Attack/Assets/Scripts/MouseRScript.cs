using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRScript : MonoBehaviour
{
    public GameObject bloco;
    public Vector2 blocoposition;
    public float horizontal, vertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(horizontal >= 0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 1.15f, transform.position.y, transform.position.z);
        }
        else if(horizontal <= -0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x - 1.15f, transform.position.y, transform.position.z);
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        vertical = Input.GetAxisRaw("Vertical");
        if (vertical >= 0.9f && Input.GetButtonDown("Vertical"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
        }
        else if (vertical <= -0.9f && Input.GetButtonDown("Vertical"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        if (Input.GetButtonDown("Fire1"))
        {
            bloco.transform.position = GameObject.Find("mouseL").GetComponent<MouseLScript>().blocoposition; //mudando o bloco de lugar.
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bloco"))
        {
            bloco = collision.gameObject; //salvando o bloco que desejo modificar.
            blocoposition = bloco.transform.position; //salvando a posição do bloco.
        }
    }
}
