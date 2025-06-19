using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Geracao
{
    public int  posz { get; set; }
    public bool criarsegmento { get; set; }

    public Geracao(int posz, bool criarsegmento)
    {
        this.posz = posz;
        this.criarsegmento = criarsegmento;

    }
}
