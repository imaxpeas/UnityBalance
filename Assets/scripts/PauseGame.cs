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

    public void TogglePause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            Debug.Log("paused");
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;
            Debug.Log("unpaused");
            isPaused=false;
        }
    }
}