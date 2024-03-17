using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }

    public void HTP()
    {
        SceneManager.LoadScene("htp");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
