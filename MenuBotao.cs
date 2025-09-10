using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBotao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Jogar()
    {
        SceneManager.LoadScene("Fase 1");
    }

    // Update is called once per frame
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Você fechou o jogo");
    }

    public void Reiniciar()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(currentScene.buildIndex);

        Time.timeScale = 1f;

        GetComponent<FirstPersonMovement>().enabled = true;
        GetComponent<Jump>().enabled = true;
        GetComponent<Crouch>().enabled = true;
        GetComponentInChildren<FirstPersonLook>().enabled = true;
        GetComponentInChildren<Zoom>().enabled = true;
    }

    public void voltarMenu()
    {
        SceneManager.LoadScene("menu");

        Time.timeScale = 1f;

        GetComponent<FirstPersonMovement>().enabled = true;
        GetComponent<Jump>().enabled = true;
        GetComponent<Crouch>().enabled = true;
        GetComponentInChildren<FirstPersonLook>().enabled = true;
        GetComponentInChildren<Zoom>().enabled = true;
    }
}
