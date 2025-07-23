using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static void ChangeScene()
    {
        int CurrentSceneID = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneID + 1 );
    }
    public static void RestartLevel()
    {
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneID);
    }
}