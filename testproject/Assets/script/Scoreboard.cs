using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorecode : MonoBehaviour
{
    public static int Score1;
    public TextMeshProUGUI ShowScore1;
    public static int Score2;
    public TextMeshProUGUI ShowScore2;

    // Start is called before the first frame update
    void Start()
    {
        Score1=0;
        Score2=0;
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore1.text = Score1.ToString();
        ShowScore2.text = Score2.ToString();
    }
}
