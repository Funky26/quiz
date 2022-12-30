using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public question[] questions;
    private static List<question> unanswaredQ;

    private question currQ;

    public TextMeshProUGUI text;

    private float delay = 2f;

    //public GameObject smileyF;
    //public GameObject sadF;

    //timer
    public float time = 10;
    public TextMeshProUGUI textBox;
    private float zero = 0;

    public TextMeshProUGUI numberQ;

    //new graphic
    public GameObject rightAnswer;
    public GameObject wrongAnswer;

    public GameObject btnClickedT;
    public GameObject btnClickedF;
    public GameObject ranOutOfTime;

    void Start()
    {

        if (unanswaredQ == null || unanswaredQ.Count==0)
        {
            unanswaredQ = questions.ToList<question>();

            //timer
            textBox.text = time.ToString();
        }

        getRandomQ();
        
    }
    void Update()
    {
        //timer
        time -= Time.deltaTime;
        textBox.text = Mathf.Round(time).ToString();
        if(textBox.text == zero.ToString())
        {
            StartCoroutine(TransitionTonextQ());
            ranOutOfTime.SetActive(true);
        }

    }

    void getRandomQ()
    {
        int randomQIndex = Random.Range(0, unanswaredQ.Count);
        currQ = unanswaredQ[randomQIndex];

        unanswaredQ.RemoveAt(randomQIndex);

        text.text = currQ.questions;
    }

    public void UserSelectT()
    {
        if(currQ.isTrue)
        {
            Debug.Log("Correct");
            //smileyF.SetActive(true);
            rightAnswer.SetActive(true);
            btnClickedT.SetActive(true);

            Destroy(textBox);
        }
        else
        {
            Debug.Log("Incorrect");
            //sadF.SetActive(true);
            wrongAnswer.SetActive(true);
            btnClickedT.SetActive(true);

            Destroy(textBox);
        }
        StartCoroutine(TransitionTonextQ());
    }

    public void UserSelectF()
    {
        if (!currQ.isTrue)
        {
            Debug.Log("Correct");
            rightAnswer.SetActive(true);
            btnClickedF.SetActive(true);

            Destroy(textBox);
        }
        else
        {
            Debug.Log("Incorrect");
            wrongAnswer.SetActive(true);
            btnClickedF.SetActive(true);

            Destroy(textBox);
        }
        StartCoroutine(TransitionTonextQ());
    }

    IEnumerator TransitionTonextQ()
    {
        unanswaredQ.Remove(currQ);

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

