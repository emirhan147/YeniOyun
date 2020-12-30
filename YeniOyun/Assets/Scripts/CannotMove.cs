using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannotMove : MonoBehaviour
{
    public bool ısCanMove;
    public Material BlackMesh, MainMesh;

    void Start()
    {
        ısCanMove = false;
    }

    
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "cntr")
        {

            GetComponent<MeshRenderer>().material = BlackMesh;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "cntr")
        {
            GetComponent<MeshRenderer>().material = MainMesh;
        }

    }
}
