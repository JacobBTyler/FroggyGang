using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sceneManager : MonoBehaviour
{


    public static float carSpeed;

    public static float spawnSpeed;

    public static string playerName;

    public static int highscore;

    public Slider carSlider;
    public Slider spawnSlider;
    public GameObject pname;

    // Start is called before the first frame update
    void Start()
    {
        carSpeed = 1.0f;

        spawnSpeed = 1.0f;

        playerName = "Player";


    }

    public void updateValues()
    {
        carSpeed = carSlider.value;
        spawnSpeed = spawnSlider.value;
        playerName = pname.GetComponent<UnityEngine.UI.Text>().text;
    }

 


}
