using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScene : MonoBehaviour
{
    public GameObject helpPanel;

    public void OutButton()
    {
        //
    }
    public void endButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title Scene");
    }
  
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PlayScene_Door 1");
    }

    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
