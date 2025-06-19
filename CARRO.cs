using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Carro
{


    public float velocidade { get; set; }
    public float velocidadehorizontal { get; set; }
    public float limitedireita { get; set; }
    public float limiteequerda { get; set; }

    public Carro(float velocidade, float velocidadehorizontal, float limitedireita, float limiteequerda)
    {
        this.velocidade = velocidade;
        this.velocidadehorizontal = velocidadehorizontal;
        this.limitedireita = limitedireita;
        this.limiteequerda = limiteequerda;
    }
}

