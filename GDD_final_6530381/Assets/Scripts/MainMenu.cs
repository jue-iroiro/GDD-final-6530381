using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame1() => SceneManager.LoadScene("MadDriver");
    public void LoadGame2() => SceneManager.LoadScene("FlyingBird");
    public void LoadGame3() => SceneManager.LoadScene("SumoBall");
    public void QuitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}

