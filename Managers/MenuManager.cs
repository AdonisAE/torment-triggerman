using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Image loadingImage;
    public Animator anim;

    public void LoadScene()
    {
        StartCoroutine(Fadingt());
    }
    public void Load1()
    {
        StartCoroutine(Fading1());
    }
    public void Load2()
    {
        StartCoroutine(Fading2());
    }

    public void QuitScene()
    {
        Application.Quit();
    }
    IEnumerator Fadingt()
    {
        GameObject.Find("MenuCanvas").SetActive(false);
        GameObject.Find("HomeScreen").SetActive(false);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => loadingImage.color.a == 1);
        SceneManager.LoadScene(1);
    }
    IEnumerator Fading1()
    {
        GameObject.Find("MenuCanvas").SetActive(false);
        GameObject.Find("HomeScreen").SetActive(false);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => loadingImage.color.a == 1);
        SceneManager.LoadScene(2);
    }
    IEnumerator Fading2()
    {
        GameObject.Find("MenuCanvas").SetActive(false);
        GameObject.Find("HomeScreen").SetActive(false);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => loadingImage.color.a == 1);
        SceneManager.LoadScene(3);
    }


}
//Code inspired by Lecture 6 GUI's and Particles