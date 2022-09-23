using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Text texto;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator paineis()
    {
        yield return new WaitForSeconds(0f);
        texto.text = "";
        yield return new WaitForSeconds(4f);
        texto.text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Scene2");
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
