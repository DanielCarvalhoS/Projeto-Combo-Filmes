using UnityEngine;
using UnityEngine.SceneManagement;


public class Jogador
{
    public int life { get; private set; }

    public Jogador(int vidaInicio)
    {
        life = vidaInicio;
    }

    public void PerdeVida()
    {
        life -= 1;
    }

    public bool Derrotado()
    {
        return life <= 0;
    }
}

public class personagemColisao : MonoBehaviour
{
    private Jogador jogador;

    void Start()
    {
        jogador = new Jogador(3); //vida inicial
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "obstaculo":
                jogador.PerdeVida();
                Debug.Log("Vidas restantes:" + jogador.life);

                if (jogador.Derrotado())
                {
                    SceneManager.LoadScene("Fase 3");
                }
                break;

            case "tesouro":
                Debug.Log("objetivo concluído!");
                break;
        }
    }

}
