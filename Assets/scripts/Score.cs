using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;

	public Text scoreText;

	void Start ()
	{
		if(CurrentScore > sceneManager.highscore) {
			sceneManager.highscore = CurrentScore;
		}
		scoreText.text = CurrentScore.ToString();
	}

}
