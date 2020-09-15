using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    public bool ısCanMove;
    public Renderer YellowMesh, MainMesh;

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
            Debug.Log("girdi");
            GetComponent<Renderer>().sharedMaterials = YellowMesh.sharedMaterials;
            GetComponent<Renderer>().sharedMaterials = YellowMesh.sharedMaterials;




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
