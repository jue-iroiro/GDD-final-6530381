using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseCanvas;
    bool isPaused = false;

    void Awake()
    {
        Time.timeScale = 1f;
        if (pauseCanvas) pauseCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TogglePause();
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        if (pauseCanvas) pauseCanvas.SetActive(isPaused);
    }

    public void Resume() => TogglePause();
    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    public void BackToMainMenu() => SceneManager.LoadScene("MainMenu");
}
