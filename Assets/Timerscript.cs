using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timerscript : MonoBehaviour
{

    public float Time_ = 0;
    public int TimeLimit = 30;
    private TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Time_ += Time.deltaTime;
        int remaining = TimeLimit - (int)Time_;

        timerText.text = remaining.ToString("f2");
    }
}
