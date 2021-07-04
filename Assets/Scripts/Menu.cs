using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Button_Start(string thisScene)
    {
        SceneManager.LoadScene(thisScene);
    }


    public void Button_Menu(string menuScene)
    {
        SceneManager.LoadScene(menuScene);
    }


    public void Button_Control(GameObject controlWindow)
    {
        controlWindow.SetActive(true);
    }


    public void ButtonExit_Control(GameObject controlWindow)
    {
        controlWindow.SetActive(false);
    }


    public void Button_Exit()
    {
        Application.Quit();
    }
}