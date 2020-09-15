using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    int x;
    int y;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void sola()
    {
        if (x >= -4)
        {
            transform.position = new Vector3(x -= 5, 1.5f, y);
        }
    }

    public void saga()
    {
        if (x <= 9)
        {
            transform.position = new Vector3(x += 5, 1.5f, y);
        }
    }
    public void ileri()
    {
        if (y <= 14)
        {
            transform.position = new Vector3(x, 1.5f, y += 5);
        }
    }
    public void geri()
    {
        if (y > 0)
        {
            transform.position = new Vector3(x, 1.5f, y -= 5);
        }
    }
}
