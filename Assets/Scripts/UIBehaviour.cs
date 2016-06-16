using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIBehaviour : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Mastergame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
    }

    void PlayAgain()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
