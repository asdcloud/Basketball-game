using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecode : MonoBehaviour
{
    public static int Score1;
    public Text ShowScore1;

    // Start is called before the first frame update
    void Start()
    {
        Score1=0;
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore1.text = Score1.ToString();
    }
}
