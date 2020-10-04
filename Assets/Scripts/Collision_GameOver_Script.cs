using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_GameOver_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene CurrentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(CurrentScene.name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.tag == "Player")
        {
            SceneManager.LoadScene("Game_Scene_GameOver");
        }
        
    }
}
