#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame() => SceneManager.LoadScene("TheGame");
    public void StartGameEndless() => SceneManager.LoadScene("TheGameEndless");
    public void GoMenu() => SceneManager.LoadScene("MainMenu");

    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
    }
    
}
