using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopHareket : MonoBehaviour
{
    Vector3 topYon;
    public float hiz;
    public ZeminSpawner zeminSpScript;
    public static bool dusenTop;
    public float hizEkle;
    public Text gameOver;

    void Start()
    {
        
        topYon = Vector3.forward;
        dusenTop = false;
       


    }
    void Update()
    {
         gameOver.gameObject.SetActive(false);
        if (transform.position.y <= 0.7f)
        {
            dusenTop = true;
            gameOver.gameObject.SetActive(true);
        }
        if (dusenTop == true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (topYon.x == 0)
            {
                topYon = Vector3.left;
            }

            else
            {
                topYon = Vector3.forward;
            }

            hiz += hizEkle * Time.deltaTime;

        }
    }

    private void FixedUpdate()
    {
        Vector3 hareket = topYon * Time.deltaTime * hiz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision cls)
    {
        if (cls.gameObject.tag.Equals("zemin"))
        {
            cls.gameObject.AddComponent<Rigidbody>();
            zeminSpScript.zemin_olustur();
            StartCoroutine(ZeminSil(cls.gameObject));
            Skor.skor += 1;

        }
    }

    IEnumerator ZeminSil(GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(2f);
        Destroy(silinecekZemin);
    }

}
