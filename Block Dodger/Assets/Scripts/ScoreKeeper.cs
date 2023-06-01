using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = ((Time.timeSinceLevelLoad)/2f).ToString("0");
    }
}
