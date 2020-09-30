using System.Collections;
using UnityEngine;


public class Instructions : MonoBehaviour
{
    //The amount of time we give to read the instructions
    public float time = 5f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
