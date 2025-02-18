using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject instructionsPanel;

    public void GoToMain()
    {
        mainMenu.SetActive(true);
        instructionsPanel.SetActive(false);
    }

    public void GoToInstructions()
    {
        mainMenu.SetActive(false);
        instructionsPanel.SetActive(true);
    }
    public void OnPlayClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
