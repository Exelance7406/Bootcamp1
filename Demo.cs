using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start()
    {



        int puan = 100;
        float katedilenMesafe = 7.0f;
        string takim = "Fenerbah�e";


        puanMethod(puan);
        katedilenMesafeMethod(katedilenMesafe);
        takimMethod(takim);





        static void puanMethod(int puan)
        {
            if (puan > 70)
            {
                Debug.Log("�ampiyon Olabilir");
            }

            else
            {
                Debug.Log("�ampiyon Olamaz");
            }
        }


        static void katedilenMesafeMethod(float katedilenMesafe)
        {
            switch (katedilenMesafe)
            {
                case 4.0f:
                    Debug.Log("Az Ko�an Tak�m");
                    break;
                case 5.0f:
                    Debug.Log("Ortalama Ko�an Tak�m");
                    break;
                case 6.0f:
                    Debug.Log("�yi Ko�an Tak�m");
                    break;
                case 7.0f:
                    Debug.Log("�ok �yi Ko�an Tak�m");
                    break;
                default:
                    Debug.Log("De�erlendirme Yap�lamad�");
                    break;


            }


        }
        static void takimMethod(string takim)
        {
            int i = 0;
            while (i < takim.Length)
            {
                Debug.Log(takim[i]);
                i++;
            }
            Debug.Log(takim[takim.Length - 1]);


        }
    }
}


