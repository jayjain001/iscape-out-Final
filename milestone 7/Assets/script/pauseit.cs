using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseit : MonoBehaviour
{

    public GameObject pausemenu;
    private bool isPaused;

    void Start()
    {
        isPaused = false;
        pausemenu.SetActive(false);
        resume(); // to start time after coming back from exit
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        isPaused = !isPaused;
        pausemenu.SetActive(isPaused);

        if (isPaused)
        {
            paused();

        }
        else
        {
            resume();
        }
    }
    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void paused()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        resume();
    }
    public void quit()
    {
        SceneManager.LoadScene("start menu");
    }
}
