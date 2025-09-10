using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{

    public class lifeBar
    {

        public Slider slider;

        public lifeBar(Slider s)
        {
            slider = s;
        }

        public void mudarHp(int life)
        {
            slider.value = life;
        }

        public void vidaMaxima(int life)
        {
            slider.maxValue = life;
            slider.value = life;
        }
    }

    private lifeBar barra;

    void Awake()
    {
        barra = new lifeBar(GetComponent<Slider>());
    }

    public void vidaMaxima(int life)
    {
        barra.vidaMaxima(life);
    }

    public void mudarHp(int life)
    {
        barra.mudarHp(life);
    }
}



