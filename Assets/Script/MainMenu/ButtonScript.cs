using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject graphicMenu;
    public GameObject renderMenu;
    public GameObject memoryMenu;

    private GameObject currentScreen;
    public void ExitAPP()
    {
        Application.Quit();
    }
    public void GraphicButton()
    {
        mainMenu.SetActive(false);
        graphicMenu.SetActive(true);
        currentScreen = graphicMenu;
    }
    public void RenderButton()
    {
        mainMenu.SetActive(false);
        renderMenu.SetActive(true);
        currentScreen = renderMenu;
    }
    public void MemoryMenu()
    {
        mainMenu.SetActive(false);
        memoryMenu.SetActive(true);
        currentScreen = memoryMenu;
    }
    public void Return()
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            mainMenu.SetActive(true);

        }
        else
        {
            Debug.Log("current screen is null");
        }
    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }




}
