using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    public void Play()
    {
        
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level_Selection");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
