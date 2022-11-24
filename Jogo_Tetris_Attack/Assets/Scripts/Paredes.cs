using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Paredes : MonoBehaviour
{
    public int num;
    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay2D(Collider2D collision)
    {
        switch (num)
        {
            case 1:
                if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
                {
                    StartCoroutine(morango());
                }
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator morango()
    {
        yield return new WaitForSeconds(0f);
        GM.texto[1].text = "Os blocos alcançaram o final! Você perdeu!";
        yield return new WaitForSeconds(4f);
        GM.texto[1].text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
