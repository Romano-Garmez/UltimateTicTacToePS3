using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class VirtualButton : MonoBehaviour
{
    public UnityEvent unityEvent;

    // Update is called once per frame
    void VOnMouseOver()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            unityEvent.Invoke();
        }
    }
}
