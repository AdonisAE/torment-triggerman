using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    // The player's score.
    public int count;
    int times;

    // Reference to the Text component.
    public Text number;
    public WaveManager wvmng;

    void Awake()
    {
        // Reset the score.
        count = 0;
    }

    void Update()
    {
        //count = wvmng.totalToSpawnForWave;
        number.text = count.ToString();
    }

    public void MinusCount(int toMinus)
    {
        count -= toMinus;
        number.GetComponent<Animation>().Stop();
        number.GetComponent<Animation>().Play();
    }

    public int GetCount()
    {
        return count;
    }
}
