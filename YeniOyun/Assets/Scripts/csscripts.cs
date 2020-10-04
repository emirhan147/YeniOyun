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
            if (collision.gameObject.tag == "canmove" || collision.gameObject.tag == "finish")
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
            move.cansola = false;
            if (collision.gameObject.tag == "canmove" || collision.gameObject.tag == "finish")
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
            move.cangeri = false;
            if (collision.gameObject.tag == "canmove" || collision.gameObject.tag == "finish")
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
            move.cansağa = false;
            if (collision.gameObject.tag == "canmove" || collision.gameObject.tag == "finish")
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
