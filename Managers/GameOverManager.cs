using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

    // Reference to the player's health.
    public PlayerHealth playerHealth;
    // Time to wait before restarting the level
    public float restartDelay = 1f;

    // Reference to the animator component.
    Animator anim;
    // Timer to count up to restarting the level
    float restartTimer;

    public Animator anim2;
    public Image black;

    void Awake() {
        // Set up the reference.
        anim = GameObject.Find("HUDCanvas").GetComponent<Animator>();
    }

    void Update() {
        //Restarter
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Restarting());
        }
            //playerHealth.TakeDamage(100);
        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0) {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");

            // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay) {
                // .. then reload the currently loaded level.
                StartCoroutine(Fading());
            }
        }
    }
    IEnumerator Fading()
    {
        anim2.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(5);
    }
    IEnumerator Restarting()
    {
        anim2.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
//Code inspiried by the Unity Survival Shooter tutorial
