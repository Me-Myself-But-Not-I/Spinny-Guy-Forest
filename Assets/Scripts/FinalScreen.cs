using System;
using TMPro;
using UnityEngine;

public class FinalScreen : MonoBehaviour
{
    public TextMeshProUGUI totalTime;
    public TextMeshProUGUI bestTime;
    public TimeSave save;

    private void Awake()
    {
        save.totalTime = 0;
        for (int i = 0; i < save.levelTimes.Length; i++)
        {
            save.totalTime += save.levelTimes[i];
        }
        totalTime.text = "Total Time: " + save.totalTime;
        bestTime.text = "Best Time: " + save.bestTime;
    }

    void Start()
    {
        if (save.totalTime > save.bestTime)
        {
            save.bestTime = save.totalTime;
        }
    }
}
