using UnityEngine;
using System.Collections;
using UnityEngine.Events;

//Control of the time and the events in the proyect

public class WaitForSeconds : MonoBehaviour
{
    [SerializeField] float seconds;
    [SerializeField] UnityEvent action;

    void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        // yield on a new YieldInstruction that waits for 5 seconds
        yield return new WaitForSecondsRealtime(seconds);
        //then:
        action.Invoke();
    }
}