using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    //public int index;
    public WaveManager tr;
    public ScoreManager sc;
    public GameObject txt;
    public Image black;
    public Animator anim;
    void Update()
    {
        if (tr.waveNumber == 1 && sc.score > 400)
        {
            txt.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            txt.SetActive(true);
        }
        else
        {
            txt.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(tr.waveNumber == 1 && sc.score > 400)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                StartCoroutine(Fading());
            }
            else if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                StartCoroutine(Fading());
            }
        }
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade",true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

//Code inspired by Dual Core Studio's "Unity: Fade Between Scenes"
