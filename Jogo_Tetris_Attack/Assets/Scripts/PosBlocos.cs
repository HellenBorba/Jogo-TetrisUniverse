using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosBlocos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public int x
    {
        get;
        private set;
    }
    public int y
    {
        get;
        private set;
    }
    public int id;

    public void PosiçãodoBloco(int newx, int newy)
    {
        x = newx;
        y = newy;
        gameObject.name = string.Format("Sprite [{0}] [{1}]", x, y);
    }
}
