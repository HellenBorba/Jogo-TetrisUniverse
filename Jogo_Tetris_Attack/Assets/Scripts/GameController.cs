using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /*
    public GameObject[] bloco;
    public GameObject mouseL, mouseR;
    private float Horizontal, Vertical;
    */
    public int points;
    public GameObject[] Bol, col;
    public Transform[] local;
    public int tempoStop;
    public Text texto;
    public float timer;

    private MouseRScript MR;
    private MouseLScript ML;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
        //----------------------------------------------------------------------------------------------------------------------------------
        Spawn1();
        Spawn2();
        Spawn3();
        Spawn4();
        Spawn5();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            Spawn1();
            Spawn2(); 
            Spawn3();
            Spawn4();
            Spawn5();
            timer = 0;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        texto.text = "Points: " + points;
        //----------------------------------------------------------------------------------------------------------------------------------
        if (Input.GetButtonDown("Fire2"))
        {
            MR.bloco.transform.position = ML.blocoposition;
            ML.bloco.transform.position = MR.blocoposition;
            if (MR.bloco.tag == ML.bloco.tag)
            {
                Destroy(ML.bloco);
                Destroy(MR.bloco);
                points += 2;
            }
            if (!col[0].CompareTag("Blue") || (!col[0].CompareTag("Purple") || (!col[0].CompareTag("Green") || (!col[0].CompareTag("Red") || (!col[0].CompareTag("Yellow"))))))
            {
                Spawn5();
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Spawn1()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
    }
    public void Spawn2()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
    }
    public void Spawn3()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
    }
    public void Spawn4()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
    }
    public void Spawn5()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Scene()
    {
        SceneManager.LoadScene(1);
    }
}
