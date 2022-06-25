using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer, timerMax, posTip, tempodescer;
    public GameObject blocoDesce, blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;

    private GameController GM;
    private int id;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        timerMax = 2;
        id = 5;
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        tempodescer += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            //----------------------------------------------------------------------------------------------------------------------------------
            if (bloco && blocoCima && blocoBaixo)
            {
                if (blocoCima.GetComponent<Colisão>().bloco && blocoBaixo.GetComponent<Colisão>().bloco)
                {
                    if (blocoCima.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoBaixo.GetComponent<Colisão>().bloco.tag == bloco.tag)
                    {
                        Destroy(blocoCima.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoBaixo.GetComponent<Colisão>().bloco);
                        GM.points += 3;
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
                        Destroy(blocoEsquerda.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoDireita.GetComponent<Colisão>().bloco);
                        GM.points += 3;
                    }
                }
            }
            //----------------------------------------------------------------------------------------------------------------------------------
            if (!bloco)
            {
                timer = 0;
                timerMax = 1;
                if (blocoDesce.GetComponent<Colisão>().bloco)
                {
                    blocoDesce.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    blocoDesce.GetComponent<Colisão>().bloco = null;
                }
                //----------------------------------------------------------------------------------------------------------------------------------
                else if (blocoDesce.GetComponent<Colisão>().bloco == false)
                {
                    switch (posTip)
                    {
                        case 1:
                            if (tempodescer >= 5)
                            {
                                GM.Spawn1();
                            }
                            break;
                        case 2:
                            if (tempodescer >= 5)
                            {
                                GM.Spawn2();
                            }
                            break;
                        case 3:
                            if (tempodescer >= 5)
                            {
                                GM.Spawn3();
                            }
                            break;
                        case 4:
                            if (tempodescer >= 5)
                            {
                                GM.Spawn4();
                            }
                            break;
                        case 5:
                            if (tempodescer >= 5)
                            {
                                GM.Spawn5();
                            }
                            break;
                    }
                }
            }
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
