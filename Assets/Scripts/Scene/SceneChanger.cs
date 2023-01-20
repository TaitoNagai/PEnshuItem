using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    [Serializable]
    class ChangeSetting
    {
        public string Scene;
        public Button Button;
    }
    [SerializeField] private float _fadeTime = 2.0f;
    [SerializeField] Fade _fade;
    [SerializeField] List<ChangeSetting> Setting;
    private void Awake()
    {
        Setting.ForEach(s =>
        {
            s.Button.onClick.AddListener(() =>
            {
                _fade.FadeIn(_fadeTime, () => SceneManager.LoadScene(s.Scene));
            });
        });
    }
}
