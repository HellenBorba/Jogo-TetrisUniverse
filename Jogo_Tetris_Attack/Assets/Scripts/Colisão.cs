using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer, timerMax, posTip, tempodescer;
    public GameObject blocoSobe, blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;

    [SerializeField]
    private int id;
    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        timerMax = 4;
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
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
                if (blocoSobe.GetComponent<Colisão>().bloco)
                {
                    if (!blocoCima)
                    {
                        blocoSobe.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        blocoSobe.GetComponent<Colisão>().bloco = null;
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------
                if (blocoSobe.GetComponent<Colisão>().bloco == false)
                {
                    switch (posTip)
                    {
                        case 1:
                            GM.Spawn1();
                            id += 1;
                            break;
                        case 2:
                            GM.Spawn2();
                            id += 1;
                            break;
                        case 3:
                            GM.Spawn3();
                            id += 1;
                            break;
                        case 4:
                            GM.Spawn4();
                            id += 1;
                            break;
                        case 5:
                            GM.Spawn5();
                            id += 1;
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
