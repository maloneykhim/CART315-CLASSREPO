using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    private Text timerText;
    private float levelTime;
    
    // Start is called before the first frame update
    public void Start() {
        timerText = GetComponent<Text>();
        ResetTimer();
    }
    
    public void ResetTimer(){
        levelTime = 30;
    }

    // Update is called once per frame
void FixedUpdate() {
    if(levelTime > 0){
        levelTime -= Time.deltaTime; // Subtract Time.deltaTime
        timerText.text = levelTime.ToString("F0") + " SECONDS LEFT"; // Convert to string and format
    }
    else {
        SceneManager.LoadScene("GameOver");
    }
}
}
