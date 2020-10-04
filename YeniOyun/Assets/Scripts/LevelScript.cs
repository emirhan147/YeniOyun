using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    public move move;

    public GameObject kazandın, kaybettin, tuşlar, kalan;

    public Text kalantext;

    public int kalansayı;

    public bool kazandınbool;

    void Start()
    {
        kazandınbool = false;
    }


    void Update()
    {
        kalansayı = 9 - move.adım;
        kalantext.text = kalansayı.ToString();

        if (move.adım > 8)
        {
            Invoke("isfinished", 0.1f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag ==  "finish" && move.adım < 10)
        {
            kazandınbool = true;
            move.enabled = false;
            tuşlar.SetActive(false);
            kazandın.SetActive(true);
        }
    }

    public void isfinished()
    {
        if(!kazandınbool)
        {
            move.enabled = false;
            kaybettin.SetActive(true);
            tuşlar.SetActive(false);
        }
    }
}
