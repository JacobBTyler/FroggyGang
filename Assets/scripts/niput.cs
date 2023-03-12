using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class niput : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public GameObject carSpawner;

    public bool paused = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(paused) {
                paused = false;
                Time.timeScale = 1.0f;
                carSpawner.SetActive(true);
            }
            else {
                paused = true;
                carSpawner.SetActive(false);
                Time.timeScale = 0.0f;
            }
        }
        if(Input.GetKeyDown(KeyCode.End)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        if(Input.GetKeyDown(KeyCode.Home)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }
}
