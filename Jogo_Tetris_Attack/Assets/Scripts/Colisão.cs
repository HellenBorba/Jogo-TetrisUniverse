using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer, timer2, timer3, timer4, posTip;
    public GameObject blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
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
        if (!bloco)
        {
            if (blocoBaixo)
            {
                if (blocoBaixo.GetComponent<Colisão>().bloco)
                {
                    timer2 += Time.deltaTime;
                    if (timer2 >= 8)
                    {
                        blocoBaixo.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        blocoBaixo.GetComponent<Colisão>().bloco = null;
                    }
                    timer = 0;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        timer += Time.deltaTime;
        if (timer >= 9)
        {
            switch (posTip)
            {
                case 1:
                    GM.Spawn1();
                    break;
                case 2:
                    GM.Spawn2();
                    break;
                case 3:
                    GM.Spawn3();
                    break;
                case 4:
                    GM.Spawn4();
                    break;
                case 5:
                    GM.Spawn5();
                    break;
            }
            timer = 0;
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
}
