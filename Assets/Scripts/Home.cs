using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    [SerializeField] TMP_Text cointText;
    private void Start()
    {
        cointText.text = PlayerPrefs.GetInt("Saved_Coins").ToString();
    }
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
