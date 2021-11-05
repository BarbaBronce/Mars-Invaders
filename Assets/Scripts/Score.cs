using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public  float score = 0;


    // Update is called once per frame
    void Update()
    {
     
        scoreText.text = score.ToString();

        if (score == 100f) SceneManager.LoadScene("WinScene");
    }



}
