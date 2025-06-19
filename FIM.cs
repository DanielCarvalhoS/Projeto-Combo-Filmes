using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FIM : MonoBehaviour
{
    public Transform menuContinuacao;
    public Transform gameOver;
    [SerializeField] private string reiniciar;

    void Update()
    {
        if (transform.position.z > 120f)
        {
            menuContinuacao.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Botao()
    {
        SceneManager.LoadScene(reiniciar);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        switch (collision.gameObject.tag)
        {
            case "obstaculo":
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0f;
                break;

        }
    }
}
