using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] Bola;
    public Transform[] local;
    public Text[] texto;
    public int points;

    [SerializeField]
    private float timer;
    private MouseRScript MR;
    private MouseLScript ML;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        StartCoroutine(tempo());
        //----------------------------------------------------------------------------------------------------------------------------------
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        texto[0].text = "Points: " + points;
        //----------------------------------------------------------------------------------------------------------------------------------
        if (Input.GetButtonDown("Fire2"))
        {
            if (ML.bloco && MR.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
                ML.bloco.transform.position = MR.transform.position;
            }
            if(!ML.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
            }
            if(!MR.bloco)
            {
                ML.bloco.transform.position = MR.transform.position;
            }
        }
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
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator tempo()
    {
        yield return new WaitForSeconds(0f);
        texto[1].text = "3";
        yield return new WaitForSeconds(1f);
        texto[1].text = "2";
        yield return new WaitForSeconds(1f);
        texto[1].text = "1";
        yield return new WaitForSeconds(1f);
        texto[1].text = "START";
        yield return new WaitForSeconds(1f);
        texto[1].text = "";
    }
}
