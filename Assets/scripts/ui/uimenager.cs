using UnityEngine;
using UnityEngine.SceneManagement;

public class uimenager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;


    private void Awake()
    {
        pauseScreen.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PauseGame(!pauseScreen.activeInHierarchy);
        }
    }
  
   

    
    public void MainMenu()
    {
        SceneManager.LoadScene("start");
    }

   
    public void Quit()
    {
        Application.Quit(); 


    }
    public void PauseGame(bool status)
    {
        
        pauseScreen.SetActive(status);

       
        if (status)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

}
