using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofElement : MonoBehaviour
{
    public bool isEntering = false;
    SpriteRenderer m_renderer;

    private void Start()
    {
        m_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(FadeOut(1));
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(FadeIn(1));
    }

    IEnumerator FadeOut(float fadeTime)
    {
        for (int i = 50; i > 6; i-=1)
        {
            Color tmp = new Color(m_renderer.color.r, m_renderer.color.g, m_renderer.color.b, i/50f);
            m_renderer.color = tmp;
            yield return new WaitForSecondsRealtime(fadeTime/50); //Wait 1 second
        }
    }
    IEnumerator FadeIn(float fadeTime)
    {
        for (int i = 6; i<50; i++)
        {
            Color tmp = new Color(m_renderer.color.r, m_renderer.color.g, m_renderer.color.b,i/50f);
            m_renderer.color= tmp;
            yield return new WaitForSecondsRealtime(fadeTime/50); //Wait 1 second
        }
    }
}
