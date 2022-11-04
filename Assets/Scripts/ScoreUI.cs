using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponent<Text>();
    }
}
