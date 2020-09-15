using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csscripts : MonoBehaviour
{
    public bool cforward, cleft, cback, cright;
    public move move;

    void Start()
    {
        if(transform.name == "cforward")
        {
            cforward = true;
        }

        if (transform.name == "cleft")
        {
            cleft = true;
        }

        if (transform.name == "cback")
        {
            cback = true;
        }

        if (transform.name == "cright")
        {
            cright = true;
        }
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(cforward)
        {
            if (collision.gameObject.tag == "canmove")
            {
                move.canileri = true;
            }

            if (collision.gameObject.tag == "cannotmove")
            {
                move.canileri = false;
            }
        }

        if (cleft)
        {
            if (collision.gameObject.tag == "canmove")
            {
                move.cansola = true;
            }

            if (collision.gameObject.tag == "cannotmove")
            {
                move.cansola = false;
            }
        }

        if (cback)
        {
            if (collision.gameObject.tag == "canmove")
            {
                move.cangeri = true;
            }

            if (collision.gameObject.tag == "cannotmove")
            {
                move.cangeri = false;
            }
        }

        if (cright)
        {
            if (collision.gameObject.tag == "canmove")
            {
                move.cansağa = true;
            }

            if (collision.gameObject.tag == "cannotmove")
            {
                move.cansağa = false;
            }
        }

    }
}
