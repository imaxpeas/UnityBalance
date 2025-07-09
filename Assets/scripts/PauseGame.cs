using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            Debug.Log("paused");
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;
            Debug.Log("unpaused");
        }
    }
}