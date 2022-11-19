using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswereQuestion : MonoBehaviour
{
    public GameObject gm;
    public GameObject smileyFace;


    public int questionCount = 5;
    public int answeredQuestions = 0;
    public int rightAnswers = 0;

    public void OnClick()
    {
        answeredQuestions++;
        if(smileyFace.activeSelf)
        {
            rightAnswers++;
        }
        if(answeredQuestions== questionCount)
        {
            Destroy(gm);
            SceneManager.LoadScene("PlayAgain");
        }
        DontDestroyOnLoad(this.gameObject);
    }


    //*mergnut* gameManager script a urobit to podla UserSelect funkcie

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
