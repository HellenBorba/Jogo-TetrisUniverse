using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer2, timer3, timer4,  timer5;
    public GameObject blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;

    private GameController GM;
    private ColisãoBase CB1;
    private ColisãoBase CB2;
    private ColisãoBase CB3;
    private ColisãoBase CB4;
    private ColisãoBase CB5;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        CB1 = GameObject.Find("Colisão (50)").GetComponent<ColisãoBase>();
        CB2 = GameObject.Find("Colisão (51)").GetComponent<ColisãoBase>();
        CB3 = GameObject.Find("Colisão (52)").GetComponent<ColisãoBase>();
        CB4 = GameObject.Find("Colisão (53)").GetComponent<ColisãoBase>();
        CB5 = GameObject.Find("Colisão (54)").GetComponent<ColisãoBase>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (bloco && blocoCima && blocoBaixo)
        {
            if (blocoCima.GetComponent<Colisão>().bloco && blocoBaixo.GetComponent<Colisão>().bloco)
            {
                if (blocoCima.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoBaixo.GetComponent<Colisão>().bloco.tag == bloco.tag)
                {
                    timer3 += Time.deltaTime;
                    if (timer3 >= 1)
                    {
                        Destroy(blocoCima.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoBaixo.GetComponent<Colisão>().bloco);
                        GM.points += 3;
                        timer3 = 0;
                    }
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (bloco && blocoDireita && blocoEsquerda)
        {
            if (blocoEsquerda.GetComponent<Colisão>().bloco && blocoDireita.GetComponent<Colisão>().bloco)
            {
                if (blocoEsquerda.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoDireita.GetComponent<Colisão>().bloco.tag == bloco.tag)
                {
                    timer4 += Time.deltaTime;
                    if (timer4 >= 1)
                    {
                        Destroy(blocoEsquerda.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoDireita.GetComponent<Colisão>().bloco);
                        GM.points += 3;
                        timer4 = 0;
                    }
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        /*
        if (!bloco)
        {
            if (blocoBaixo)
            {
                if (blocoBaixo.GetComponent<Colisão>().bloco)
                {
                    timer2 += Time.deltaTime;
                    if (timer2 >= 2)
                    {
                        blocoBaixo.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        blocoBaixo.GetComponent<Colisão>().bloco = null;
                    }
                    timer2 = 0;
                }
            }
        }
        */
        if(bloco)
        {
            timer2 += Time.deltaTime;
            if(timer2 >= 1)
            {
                blocoBaixo.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
                blocoBaixo.GetComponent<Colisão>().bloco = null;
                CB1.bloco = null;
                CB2.bloco = null;
                CB3.bloco = null;
                CB4.bloco = null;
                CB5.bloco = null;
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
