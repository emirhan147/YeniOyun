using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public bool canileri, cansola, cangeri, cansağa;
    public int adım;
    
    void Start()
    {
        adım = 0;
    }

    // Update is called once per frame
    public void sola()
    {
        if (cansola)
        {
            transform.position = new Vector3(transform.position.x - 5, 5.5f, transform.position.z);
            adım += 1;
        }
    }

    public void saga()
    {
        if (cansağa)
        {
            transform.position = new Vector3(transform.position.x + 5, 5.5f, transform.position.z);
            adım += 1;
        }
    }
    public void ileri()
    {
        if (canileri)
        {
            transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z + 5);
            adım += 1;
        }
    }
    public void geri()
    {
        if (cangeri)
        {
            transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z - 5);
            adım += 1;
        }
    }
}
