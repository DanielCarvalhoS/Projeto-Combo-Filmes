using System.Collections;
using UnityEngine;

public class MAPA : MonoBehaviour
{
    public GameObject segmento;
    public Geracao mapa = new Geracao(60, false);

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            if (mapa.criarsegmento == false)
            {
                mapa.criarsegmento = true;
                StartCoroutine(Gerasegmentos());
            }
        }
        
    }

    IEnumerator Gerasegmentos()
    {
        Instantiate(segmento, new Vector3(-5,-22 ,mapa.posz), Quaternion.identity);
        mapa.posz += 30;
        yield return new WaitForSeconds(1);
        mapa.criarsegmento=false;
    }
}
