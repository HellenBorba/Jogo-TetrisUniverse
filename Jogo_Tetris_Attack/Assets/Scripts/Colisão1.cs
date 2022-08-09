using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisão1 : MonoBehaviour
{
    public GameObject panel;
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            StartCoroutine(morango());
        }
    }
    IEnumerator morango()
    {
        yield return new WaitForSeconds(0f);
        panel.SetActive(true);
        yield return new WaitForSeconds(3f);
        panel.SetActive(false);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
