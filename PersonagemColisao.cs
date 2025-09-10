using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PersonagemColisao : MonoBehaviour
{

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

    private Jogador jogador;

    public BarraVida barra;
    public int life = 4;
    public bool gameOver = false;
    public GameObject painelVida;
    public GameObject painelDerrota;


    void Start()
    {
        Debug.Log("rodou o start");
        jogador = new Jogador(4); //vida inicial
        barra.vidaMaxima(life);

        painelVida.SetActive(true);
        painelDerrota.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case "obstaculo":
                jogador.PerdeVida();
                barra.mudarHp(jogador.life);
                Debug.Log("Vidas restantes:" + jogador.life);

                if (jogador.Derrotado())
                {
                    //SceneManager.LoadScene("Fase 3");
                    gameOver = true;
                }
                break;

            case "tesouro":
                SceneManager.LoadScene("Fase 4");
                break;

            case "saidaF":
                gameOver = true;
                Debug.Log("colidiu!");
                Debug.Log(gameOver);
                break;

            case "saidaV":
                SceneManager.LoadScene("Fase 5");
                break;
        }

        if (gameOver)
        {
            Time.timeScale = 0f;

            GetComponent<FirstPersonMovement>().enabled = false;
            GetComponent<Jump>().enabled = false;
            GetComponent<Crouch>().enabled = false;
            GetComponentInChildren<FirstPersonLook>().enabled = false;
            GetComponentInChildren<Zoom>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            mostrarTela();
        }
    }

    void mostrarTela()
    {
        painelVida.SetActive(false);
        painelDerrota.SetActive(true);
    }

}
