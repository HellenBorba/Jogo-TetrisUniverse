using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameController : MonoBehaviour
{
    public GameObject panel;
    public int id;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        StartCoroutine(tempo());
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        id = PlayerPrefs.GetInt("a");
        if(id>= 1)
        {
            Destroy(panel);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Play()
    {
        SceneManager.LoadScene("Fase1");
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Sair()
    {
        Application.Quit();
        PlayerPrefs.SetInt("a", 0);
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator tempo()
    {
        yield return new WaitForSeconds(0f);
        panel.SetActive(true);
        yield return new WaitForSeconds(24f);
        PlayerPrefs.SetInt("a", 1);
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
