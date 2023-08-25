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
        string takim = "Fenerbahçe";


        puanMethod(puan);
        katedilenMesafeMethod(katedilenMesafe);
        takimMethod(takim);





        static void puanMethod(int puan)
        {
            if (puan > 70)
            {
                Debug.Log("Þampiyon Olabilir");
            }

            else
            {
                Debug.Log("Þampiyon Olamaz");
            }
        }


        static void katedilenMesafeMethod(float katedilenMesafe)
        {
            switch (katedilenMesafe)
            {
                case 4.0f:
                    Debug.Log("Az Koþan Takým");
                    break;
                case 5.0f:
                    Debug.Log("Ortalama Koþan Takým");
                    break;
                case 6.0f:
                    Debug.Log("Ýyi Koþan Takým");
                    break;
                case 7.0f:
                    Debug.Log("Çok Ýyi Koþan Takým");
                    break;
                default:
                    Debug.Log("Deðerlendirme Yapýlamadý");
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


