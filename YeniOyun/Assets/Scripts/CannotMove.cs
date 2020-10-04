using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannotMove : MonoBehaviour
{
    public bool ısCanMove;
    public Renderer BlackMesh, MainMesh;

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

            GetComponent<Renderer>().sharedMaterials = BlackMesh.sharedMaterials;
            GetComponent<Renderer>().sharedMaterials = BlackMesh.sharedMaterials;




        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "cntr")
        {
            GetComponent<Renderer>().sharedMaterials = MainMesh.sharedMaterials;
            GetComponent<Renderer>().sharedMaterials = MainMesh.sharedMaterials;
        }

    }
}
