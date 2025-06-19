using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class MOVIMENTO : MonoBehaviour
{
    public Carro car = new Carro(8f, 5f, 5f, -0.5f);
   
    void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            movimento();
        }
       
    }
    public void movimento()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * car.velocidade, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > car.limiteequerda)
            {
                transform.Translate(Vector3.left * Time.deltaTime * car.velocidadehorizontal);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < car.limitedireita)
            {
                transform.Translate(Vector3.right * Time.deltaTime * car.velocidadehorizontal);
            }
        }
    }
}
