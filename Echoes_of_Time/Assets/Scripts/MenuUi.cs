using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour
{
    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
