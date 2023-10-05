using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int vidas = 3;
    private static int frutas = 0;
    [SerializeField]
    public TextMeshProUGUI texto;
    public TextMeshProUGUI TextVidas;
    public GameObject gameOver;
    public GameObject fimJogo;

    public static GameController instance;

    private void Start()
    {
        instance = this;
    }
    private void FixedUpdate()
    {
        texto.text = frutas.ToString();
        TextVidas.text = vidas.ToString();
    }

    public static void somaFruta() {
        frutas++;
    }
    
    public static void diminuiVida()
    {
        vidas--;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        vidas = 3;
        frutas = 0;

    }

    public void Showfimjogo()
    {
        fimJogo.SetActive(true);

    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
