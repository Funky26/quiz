using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdown : MonoBehaviour
{
    public float time = 10;
    public TextMeshProUGUI textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        textBox.text =Mathf.Round(time).ToString();
    }
}
