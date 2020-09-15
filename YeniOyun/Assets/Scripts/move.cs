using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public bool canileri, cansola, cangeri, cansağa;
    
    void Start()
    {

    }

    // Update is called once per frame
    public void sola()
    {
        if (cansola)
        {
            transform.position = new Vector3(transform.position.x - 5, 2.5f, transform.position.z);
        }
    }

    public void saga()
    {
        if (cansağa)
        {
            transform.position = new Vector3(transform.position.x + 5, 2.5f, transform.position.z);
        }
    }
    public void ileri()
    {
        if (canileri)
        {
            transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z + 5);
        }
    }
    public void geri()
    {
        if (cangeri)
        {
            transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z - 5);
        }
    }
}
