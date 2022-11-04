using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class gameManager : MonoBehaviour
{
    public question[] questions;
    private static List<question> unanswaredQ;

    private question currQ;

    // Start is called before the first frame update
    void Start()
    {
        if (unanswaredQ == null || unanswaredQ.Count==0)
        {
            unanswaredQ = questions.ToList<question>();
        }
    }

    //11.55
}

