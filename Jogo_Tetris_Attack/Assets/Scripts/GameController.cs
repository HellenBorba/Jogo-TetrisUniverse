using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int points;
    public GameObject[] Bola, col;
    public Transform[] local;
    public Text texto;

    [SerializeField]
    private float timer;
    private MouseRScript MR;
    private MouseLScript ML;
    private int contagem;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            if (contagem < 30)
            {
                Spawn0();
                timer = 0;
            }
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
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Spawn0()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
        contagem += 5;
    }
    //----------------------------------------------------------------------------------------------------------------------------------
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
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Scene()
    {
        SceneManager.LoadScene(1);
    }
}
