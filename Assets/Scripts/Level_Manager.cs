using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0f, -9.81f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
