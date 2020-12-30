using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    public bool ısCanMove;
    public Material YellowMesh, MainMesh;

    void Start()
    {
        ısCanMove = true;
    }

    
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "cntr")
        {

            GetComponent<MeshRenderer>().material = YellowMesh;
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
