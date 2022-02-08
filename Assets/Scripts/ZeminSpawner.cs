using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject son_zemin;


    void Start()
    {
        for (int i = 0; i < 15; i++)
        {        
            zemin_olustur();
        }

    }

    void Update()
    {
        
    }

    public void zemin_olustur()
    {
        Vector3 topYon;
        if (Random.Range(0, 2) == 0)
        {
            topYon= Vector3.forward;
        }
        else
        {
            topYon = Vector3.left;
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + topYon, son_zemin.transform.rotation);
        
    }
}
