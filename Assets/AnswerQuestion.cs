using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerQuestion : MonoBehaviour
{
    public Toggle correctAnswer;
    public void isCorrect()
    {
        if(correctAnswer.isOn)
        {
            Debug.Log("Correct!");
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Not correct!");
            SceneManager.LoadScene(1);
        }
    }
}
