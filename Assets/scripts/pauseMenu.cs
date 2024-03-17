
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausemenu;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!pausemenu.activeSelf)
            {
                Time.timeScale = 0f;
                pausemenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pausemenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }
    public void quit()
    {
        Application.Quit();
    }

    public void resume()
    {
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
        Cursor.visible = false;
    }
}
