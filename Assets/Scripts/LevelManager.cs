using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class LevelManager : MonoBehaviour
{
    [SerializeField] TMP_Text cointext;
    int coin;
    [SerializeField] TMP_Text levelNo;
    [SerializeField] int nextLevel;
    void Start()
    {
        coin = 0; 
        levelNo.text = $"Level {SceneManager.GetActiveScene().buildIndex}";
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void LevelDelay()
    {
        SceneManager.LoadScene(nextLevel);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Water"))
        {
            Invoke("Reload", 4f);
        }
        if(other.gameObject.CompareTag("Finish"))
        {
            if(nextLevel > PlayerPrefs.GetInt("Unlocked_Level"))
            {
                PlayerPrefs.SetInt("Unlocked_Level", nextLevel);
            }
            coin += PlayerPrefs.GetInt("Saved_Coins");
            PlayerPrefs.SetInt("Saved_Coins", coin);
            Invoke("LevelDelay", 2f);
        }
        if(other.gameObject.CompareTag("Coin"))
        {
            coin++;
            cointext.text = coin.ToString();
            Destroy(other.gameObject);
        }
    } 
}
