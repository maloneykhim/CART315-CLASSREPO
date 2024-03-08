using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    private Text scoreText; // Change the type to Text

    private int score;

    public static ScoreScript S;
    
    // Start is called before the first frame update
    void Start() {
        score = 0; // No need to cast 0.0f to int, just use 0
        scoreText = GetComponent<Text>(); // Get the Text component
        DisplayScore();
        S = this;
    }

    public void IncreaseScore() {
        score++;
        DisplayScore();
    }
    
    public void DecreaseScore() {
        
        score--;
        DisplayScore();
}

    private void DisplayScore() {
        scoreText.text = "SCORE: " + score;
    }
}

