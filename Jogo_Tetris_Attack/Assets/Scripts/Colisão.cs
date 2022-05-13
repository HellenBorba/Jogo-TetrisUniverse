using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    private GameController GM;
    private BlocoDescendo BD;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        BD = GameObject.Find("Bloquinho").GetComponent<BlocoDescendo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Col") || (!collision.gameObject.CompareTag("Blue") || (!collision.gameObject.CompareTag("Purple") || (!collision.gameObject.CompareTag("Green") || (!collision.gameObject.CompareTag("Red") || (!collision.gameObject.CompareTag("Yellow")))))))
        {
            if (transform.parent.GetComponent<BlocoDescendo>().stop == 1)
            {
                transform.parent.position = new Vector3(transform.parent.position.x, transform.parent.position.y - 1.15f, transform.parent.position.z);
            }
        }
    }
}
