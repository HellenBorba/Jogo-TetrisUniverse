using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoDescendo : MonoBehaviour
{
    [SerializeField]
    public float time, stop;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        time += Time.deltaTime;
        if (stop == 1)
        {

        } else
        if (time >= 1)
          {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            time = 0;
          }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Col") || (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow")))))))
        {
            if (stop == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
                stop = 1;
            }
        }
        if (!GM.col[0].CompareTag("Blue") || (!GM.col[0].CompareTag("Purple") || (!GM.col[0].CompareTag("Green") || (!GM.col[0].CompareTag("Red") || (!GM.col[0].CompareTag("Yellow"))))))
        {
            GM.Spawn1();
        }
    }
} 
