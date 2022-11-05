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

    // Start is called before the first frame update
    void Start()
    {
        if (unanswaredQ == null || unanswaredQ.Count==0)
        {
            unanswaredQ = questions.ToList<question>();
        }

        getRandomQ();
        
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
        }
        else
        {
            Debug.Log("Incorrect");
        }

        StartCoroutine(TransitionTonextQ());
    }

    public void UserSelectF()
    {
        if (!currQ.isTrue)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Incorrect");
        }
        StartCoroutine(TransitionTonextQ());
    }

    IEnumerator TransitionTonextQ()
    {
        unanswaredQ.Remove(currQ);

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //11.55
}

