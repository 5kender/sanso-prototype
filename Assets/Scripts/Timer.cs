using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float startTime;
    private bool stopTimer;
    public TMP_Text timerText;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        if (!stopTimer)
        {
            float t = Time.time - startTime;

            // Afficher dans le format mm:ss
            string minutes = ((int)t / 60).ToString("00");
            string seconds = ((int)t % 60).ToString("00");

            timerText.text = minutes + ":" + seconds;
        } 
    }
    public void Reset()
    {
        stopTimer = false;
        startTime = Time.time;
    }

    public void Stop()
    {
        stopTimer = true;

        float t = Time.time - startTime;

        // Afficher dans le format mm:ss.ddd
        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("f3");

        timerText.text = minutes + ":" + seconds;
    }
}
