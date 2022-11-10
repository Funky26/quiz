using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{

    public GameObject smileyF;
    public TextMeshProUGUI games;
    public int one=1;
    public int endGame=10;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        games.text = one.ToString() + " / " + endGame.ToString();
        if (smileyF == true)
        {
            one++;
        }
        if (one == endGame)
        {
            SceneManager.LoadScene("PlayAgain");
            one = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (smileyF == true)
        {
            one++;
        }
    }
}
