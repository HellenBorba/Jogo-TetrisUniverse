using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão_DEBaixo : MonoBehaviour
{
    public float timer1, timer2, timer3, timer4, timer5;
    public GameObject bloco, blocoCima;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        //----------------------------------------------------------------------------------------------------------------------------------
        if (!bloco)
        {
            if (blocoCima.GetComponent<Colisão>().bloco)
            {
                blocoCima.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
                blocoCima.GetComponent<Colisão>().bloco = null;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
}
