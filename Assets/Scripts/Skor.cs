using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public static int skor;
    public Text skorText;

    private int skorTotal;

    void Start()
    {
        skor = 0;
    }

    
    void Update()
    {
        skorTotal = skor / 5 ;
        skorText.text = skorTotal.ToString();
    }
}
