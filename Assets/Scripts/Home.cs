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
        int unlocked_Level = PlayerPrefs.GetInt("Unlocked_Level", 1);
        SceneManager.LoadScene(unlocked_Level);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level_Selection");
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
