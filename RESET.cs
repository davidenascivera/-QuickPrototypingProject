using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RESET : MonoBehaviour
{
    public string url;
    public bool PrimaVolta = true;
    public void open()
    {
        if (PrimaVolta == true)
        {
            StartCoroutine(GetRequest(url));
            PrimaVolta = false;
        }
        Debug.Log("resettato");

    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

        }
    }
}