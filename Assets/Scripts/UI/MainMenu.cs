using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int sceneToContinue;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Continue()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        }
        else
        {
            return;
        }
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("SettingMenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Exit play mode only work when in unity editor
        #endif
    }


}
