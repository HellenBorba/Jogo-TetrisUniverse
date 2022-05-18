using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer;
    public GameObject bloco;
    public GameObject blocoCima;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1)
        {
            BlocoCima();
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void OnTriggerStay2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void BlocoCima()
    {
        if (!bloco)
        {
            blocoCima.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            /*
             if (blocoCima.GetComponent<Colisão>().bloco)
             {
                   blocoCima.GetComponent<Colisão>().bloco.transform.position = new Vector3(bloco.transform.position.x, bloco.transform.position.y, bloco.transform.position.z);
             }
            */
        }
    }
}
