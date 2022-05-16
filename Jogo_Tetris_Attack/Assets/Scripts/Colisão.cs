using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer;
    public GameObject bloco;
    public GameObject blocoCima;

    private GameController GM;
    private BlocoDescendo BD;
    // Start is called before the first frame update
    void Start()
    {
        BD = GetComponentInParent<BlocoDescendo>();
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >=0)
        {
            if (bloco)
            {
                if (blocoCima.GetComponent<Colisão>().bloco)
                {
                    blocoCima.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                }
            }
        }
    }
    public void OnTriggerStay2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
}
