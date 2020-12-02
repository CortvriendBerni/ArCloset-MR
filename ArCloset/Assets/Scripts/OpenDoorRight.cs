using System.Collections;
using UnityEngine;

public class OpenDoorRight : MonoBehaviour
{
    private bool doorOpened;
    private bool coroutineAllowed;

    // Start is called before the first frame update
    void Start()
    {
        doorOpened = false;
        coroutineAllowed = true;
    }

    private void OnMouseDown()
    {
        Invoke("RunCoroutine", 0f);
    }

    private void RunCoroutine()
    {
        StartCoroutine("OpenThatDoor");
    }

    private IEnumerator OpenThatDoor()
    {
        coroutineAllowed = false;
        if (!doorOpened)
        {
            for (float i = 0f; i <= 140f; i += 3f)
            {
                transform.localRotation = Quaternion.Euler(-180f, 0f, i);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = true;
        }
        else
        {
            for (float i = 140f; i >= 0f; i -= 3f)
            {
                transform.localRotation = Quaternion.Euler(-180f, 0f, i);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = false;
        }
        coroutineAllowed = true;
    }
}
