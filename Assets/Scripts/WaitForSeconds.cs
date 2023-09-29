using UnityEngine;
using System.Collections;
using UnityEngine.Events;

//Patricia Gracia Artero
//Free to use

public class WaitForSeconds : MonoBehaviour
{
    public float seconds;
    public UnityEvent action;

    void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        // yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(seconds);
        //then:
        action.Invoke();
    }
}