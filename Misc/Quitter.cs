using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Quitter : MonoBehaviour
{
    public Image loadImage;
    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        //IF the user presses Q
        if (Input.GetKeyDown(KeyCode.Q)){

            //Quit to main menu
            StartCoroutine(Fading());
        }

            
    }
    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => loadImage.color.a == 1);
        SceneManager.LoadScene(0);
    }
}
