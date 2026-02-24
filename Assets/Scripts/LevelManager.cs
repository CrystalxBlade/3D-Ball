using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int nextLevel;
    void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update()
    {
        
    }
    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Water"))
        {
            Invoke("Reload", 4f);
        }
        if(other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    } 
}
