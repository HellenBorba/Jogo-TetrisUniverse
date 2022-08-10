using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColisãoDerrota : MonoBehaviour
{
    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            StartCoroutine(morango());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator morango()
    {
        yield return new WaitForSeconds(0f);
        GM.texto[2].text = "Os blocos alcançaram o final! Você perdeu";
        yield return new WaitForSeconds(4f);
        GM.texto[2].text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
