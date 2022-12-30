using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswereQuestion : MonoBehaviour
{
    public GameObject gm;
    public GameObject smileyFace;
    public Button True;
    public Button False;


    public int questionCount = 5;
    public int answeredQuestions = 0;
    public int rightAnswers = 0;



    public static AnswereQuestion Instance;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        //DontDestroyOnLoad(this);
        answeredQuestions++;
    }
    void Update()
    {
        True.onClick.AddListener(QuestionCount);
        False.onClick.AddListener(QuestionCount);
        

        if (answeredQuestions == questionCount)
        {
            Destroy(gm);
            SceneManager.LoadScene("PlayAgain");
        }
    }

    void QuestionCount()
    {
        if (smileyFace.activeSelf)
        {
            rightAnswers++;
        }
    }
}
