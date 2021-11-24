using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TitleCanvas : MonoBehaviour
{


    CanvasGroup canvasGroup;
    PlayableDirector playableDirector;
    private void Start()
    {
        canvasGroup = FindObjectOfType<CanvasGroup>();
        playableDirector = FindObjectOfType<PlayableDirector>();
    }
    public void JYSText()
    {
        StartCoroutine("FadeIn");

    }


    IEnumerator FadeIn()
    {
        while (canvasGroup.alpha != 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2f;

            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        playableDirector.Play();

        gameObject.SetActive(false);
        yield break;
    }
}
