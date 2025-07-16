using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        Debug.Log("check");
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}