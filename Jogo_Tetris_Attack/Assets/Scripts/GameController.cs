using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] Bola, Colisoes;
    public Transform[] local;
    public Text[] texto;
    public int points, pontosFase, tempoFase;

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
        texto[0].text = "Pointos: " + points;
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
        if(Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    #region Spawns
    public void Spawn1()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
    }
    public void Spawn2()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
    }
    public void Spawn3()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
    }
    public void Spawn4()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
    }
    public void Spawn5()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------
}
