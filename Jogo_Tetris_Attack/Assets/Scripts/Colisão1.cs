using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisão1 : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            SceneManager.LoadScene(0);
        }
    }
}
