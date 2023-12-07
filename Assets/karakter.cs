using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    public GameObject[] noktarlar;
    Transform gecerliNokta;
    Vector3 poz;
    int devriyeNoktaSayisi=0;
    void Start()
    {
        gecerliNokta = noktarlar[0].transform;   
    }

    void Update()
    {
        poz = gecerliNokta.position - transform.position;
        transform.Translate(poz.normalized * 6f * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position,gecerliNokta.position) <= .1f)
        {
            BirSonrakiPozisyonaGit();
        }

    }

    void BirSonrakiPozisyonaGit()
    {
        if (devriyeNoktaSayisi >= noktarlar.Length - 1)
        {
            Debug.Log("bitti");
            return;
        }
        devriyeNoktaSayisi++;
        gecerliNokta = noktarlar[devriyeNoktaSayisi].transform;
    }
}
