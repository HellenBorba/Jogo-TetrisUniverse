using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer1, timer2, timer3, timer4;
    public GameObject blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;
    public int posTip, id;

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
                    timer1 += Time.deltaTime;
                    if (timer1 >= 1)
                    {
                        Destroy(blocoCima.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoBaixo.GetComponent<Colisão>().bloco);
                        GM.points += 3;
                        timer1 = 0;
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
                    timer2 += Time.deltaTime;
                    if (timer2 >= 1)
                    {
                        Destroy(blocoEsquerda.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoDireita.GetComponent<Colisão>().bloco);
                        GM.points += 3;
                        timer2 = 0;
                    }
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (!bloco)
        {
            if (blocoBaixo.GetComponent<Colisão>().bloco)
            {
                blocoBaixo.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                blocoBaixo.GetComponent<Colisão>().bloco = null;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        timer4 += Time.deltaTime;
        if (timer4 >= GM.tempoFase)
        {
            id++;
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
            timer4 = 0;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (id == 0)
        {
            GM.Colisoes[39].SetActive(true);
            GM.Colisoes[38].SetActive(true);
            GM.Colisoes[37].SetActive(true);
            GM.Colisoes[36].SetActive(true);
            GM.Colisoes[35].SetActive(true);
        }
        if(id == 1)
        {
            GM.Colisoes[30].SetActive(true);
            GM.Colisoes[31].SetActive(true);
            GM.Colisoes[32].SetActive(true);
            GM.Colisoes[33].SetActive(true);
            GM.Colisoes[34].SetActive(true);
        }
        if(id == 2)
        {
            GM.Colisoes[29].SetActive(true);
            GM.Colisoes[28].SetActive(true);
            GM.Colisoes[27].SetActive(true);
            GM.Colisoes[26].SetActive(true);
            GM.Colisoes[25].SetActive(true);
        }
        if(id == 3)
        {
            GM.Colisoes[20].SetActive(true);
            GM.Colisoes[21].SetActive(true);
            GM.Colisoes[22].SetActive(true);
            GM.Colisoes[23].SetActive(true);
            GM.Colisoes[24].SetActive(true);
        }
        if(id == 4)
        {
            GM.Colisoes[19].SetActive(true);
            GM.Colisoes[18].SetActive(true);
            GM.Colisoes[17].SetActive(true);
            GM.Colisoes[16].SetActive(true);
            GM.Colisoes[15].SetActive(true);
        }
        if(id == 5)
        {
            GM.Colisoes[10].SetActive(true);
            GM.Colisoes[11].SetActive(true);
            GM.Colisoes[12].SetActive(true);
            GM.Colisoes[13].SetActive(true);
            GM.Colisoes[14].SetActive(true);
        }
        if(id == 6)
        {
            GM.Colisoes[9].SetActive(true);
            GM.Colisoes[8].SetActive(true);
            GM.Colisoes[7].SetActive(true);
            GM.Colisoes[6].SetActive(true);
            GM.Colisoes[5].SetActive(true);
        }
        if(id == 7)
        {
            GM.Colisoes[0].SetActive(true);
            GM.Colisoes[1].SetActive(true);
            GM.Colisoes[2].SetActive(true);
            GM.Colisoes[3].SetActive(true);
            GM.Colisoes[4].SetActive(true);
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
