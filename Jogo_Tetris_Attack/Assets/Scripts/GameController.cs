using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] Bola, Colisoes;
    public GameObject Sobe;
    public Transform[] local;
    public Text[] texto;
    public int points, pontosFase, tempoFase, id;

    private float recebe = 18.24f, xS = 0.0056f, timer5;
    private MouseRScript MR;
    private MouseLScript ML;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        texto[0].text = "Pontos: " + points;
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Botão R
        if (Input.GetButtonDown("Fire2"))
        {
            if (ML.bloco && MR.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
                ML.bloco.transform.position = MR.transform.position;
            }else
            if(!ML.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
            }else
            {
                ML.bloco.transform.position = MR.transform.position;
            }
        }
        #endregion
        if (Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Menu");
        }
        timer5 += Time.deltaTime;
        if(timer5 >= tempoFase)
        {
            id += 1;
            recebe = Sobe.transform.position.y + 1.15f;
            Sobe.transform.position = Vector3.Lerp(transform.position, new Vector2(xS, recebe), 4);
            timer5 = 0;
        }
        #region ids
        if (id == 1)
        {
            Colisoes[39].SetActive(true);
            Colisoes[38].SetActive(true);
            Colisoes[37].SetActive(true);
            Colisoes[36].SetActive(true);
            Colisoes[35].SetActive(true);
        }
        if (id == 2)
        {
            Colisoes[30].SetActive(true);
            Colisoes[31].SetActive(true);
            Colisoes[32].SetActive(true);
            Colisoes[33].SetActive(true);
            Colisoes[34].SetActive(true);
        }
        if (id == 3)
        {
            Colisoes[29].SetActive(true);
            Colisoes[28].SetActive(true);
            Colisoes[27].SetActive(true);
            Colisoes[26].SetActive(true);
            Colisoes[25].SetActive(true);
        }
        if (id == 4)
        {
            Colisoes[20].SetActive(true);
            Colisoes[21].SetActive(true);
            Colisoes[22].SetActive(true);
            Colisoes[23].SetActive(true);
            Colisoes[24].SetActive(true);
        }
        if (id == 5)
        {
            Colisoes[19].SetActive(true);
            Colisoes[18].SetActive(true);
            Colisoes[17].SetActive(true);
            Colisoes[16].SetActive(true);
            Colisoes[15].SetActive(true);
        }
        if (id == 6)
        {
            Colisoes[10].SetActive(true);
            Colisoes[11].SetActive(true);
            Colisoes[12].SetActive(true);
            Colisoes[13].SetActive(true);
            Colisoes[14].SetActive(true);
        }
        if (id == 7)
        {
            Colisoes[9].SetActive(true);
            Colisoes[8].SetActive(true);
            Colisoes[7].SetActive(true);
            Colisoes[6].SetActive(true);
            Colisoes[5].SetActive(true);
        }
        if (id == 8)
        {
            Colisoes[0].SetActive(true);
            Colisoes[1].SetActive(true);
            Colisoes[2].SetActive(true);
            Colisoes[3].SetActive(true);
            Colisoes[4].SetActive(true);
        }
        #endregion
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
