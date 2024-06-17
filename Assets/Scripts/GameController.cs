using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField, Tooltip("Game Dutarion")]
    private float timer = 10f;
    [SerializeField, Tooltip("Game Timer Text")]
    private TextMeshProUGUI textTimer;

    // Start is called before the first frame update
    void Start()
    {
        FoodBehavior.quantity = 0; //no food collected
        Invoke("GoToGameOver", timer); //go to game over after time seconds
        textTimer.text = "TIMER: " + timer.ToString();
        InvokeRepeating("DecTimer", 1f, 1f);
    }

    void GoToGameOver()
    {
        SceneManager.LoadScene(2);
    }

    private void DecTimer()
    {
        timer -= 1;
        textTimer.text = "TIMER: " + timer.ToString();
    }
}
