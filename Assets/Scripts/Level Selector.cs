using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] int levelNo;

    private void Start()
    {
        if(levelNo <= PlayerPrefs.GetInt("Unlocked_Level",1))
        {
            gameObject.GetComponent<Button>().interactable = true; 
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
    public void Loadlvl()
    {
        SceneManager.LoadScene(levelNo);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
