using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField, Tooltip("Game Timer Text")]
    private TextMeshProUGUI foodCount;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoToMenu", 5); //go to menu after 5 seconds
        foodCount.text = "Parabéns: Você coletou " + FoodBehavior.quantity.ToString() + " pedaços de pizzas."; //Show how many clicks was right
    }

    void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
