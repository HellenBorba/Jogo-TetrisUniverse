using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLScript : MonoBehaviour
{
    public GameObject bloco;
    public Vector2 blocoposition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
          //  bloco.transform.position = GameObject.Find("mouseR").GetComponent<MouseRScript>().blocoposition; //mudando o bloco de lugar.
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
