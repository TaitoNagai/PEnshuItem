using System.Collections;
using UnityEngine;

public class Fade : MonoBehaviour
{
    IFade fade;

    void Start()
    {
        Init();
        fade.Range = _cutoutRange;
    }

    float _cutoutRange;

    void Init()
    {
        fade = GetComponent<IFade>();
    }

    void OnValidate()
    {
        Init();
        fade.Range = _cutoutRange;
    }

    IEnumerator FadeOutCoroutine(float time, System.Action action)
    {
        float _endTime = Time.timeSinceLevelLoad + time * (_cutoutRange);

        var _endFrame = new WaitForEndOfFrame();

        while(Time.timeSinceLevelLoad <= _endTime)
        {
            _cutoutRange = (_endTime - Time.timeSinceLevelLoad) / time;
            fade.Range = _cutoutRange;
            yield return _endFrame;
        }
        _cutoutRange = 0;
        fade.Range = _cutoutRange;

        if(action != null)
        {
            action();
        }
    }

    IEnumerator FadeInCoroutine(float time, System.Action action)
    {
        float endTime = Time.timeSinceLevelLoad + time * (1 - _cutoutRange);

        var endFrame = new WaitForEndOfFrame();

        while (Time.timeSinceLevelLoad <= endTime)
        {
            _cutoutRange = 1 - ((endTime - Time.timeSinceLevelLoad) / time);
            fade.Range = _cutoutRange;
            yield return endFrame;
        }
        _cutoutRange = 1;
        fade.Range = _cutoutRange;
    }

    public Coroutine FadeOut(float time, System.Action action)
    {
        StopAllCoroutines();
        return StartCoroutine(FadeOutCoroutine(time, action));
    }

    public Coroutine FadeOut(float time)
    {
        return FadeOut(time, null);
    }

    public Coroutine FadeIn(float time, System.Action action)
    {
        StopAllCoroutines();
        return StartCoroutine(FadeInCoroutine(time, action));
    }
    public Coroutine FadeIn(float time)
    {
        return FadeIn(time, null);
    }

    public interface IFade
    {
        float Range { get; set; }
    }
}
