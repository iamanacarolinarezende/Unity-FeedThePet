using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviourScript : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene(1);
    }
}
