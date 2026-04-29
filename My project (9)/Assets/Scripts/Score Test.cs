using TMPro;
using UnityEngine;

public class ScoreTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI stage1;
    public TextMeshProUGUI stage2;
    public TextMeshProUGUI stage3;

    void Start()
    {
        stage1.text = "STAGE 1 : " + HighScore.Load(1).ToString();
        stage2.text = "STAGE 2 : " + HighScore.Load(2).ToString();
        stage3.text = "STAGE 3 : " + HighScore.Load(3).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
