using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascondiScopri : MonoBehaviour
{
    public void Mostra (GameObject obj)
    {
        obj.SetActive(true);
    }
    public void Nascondi(GameObject obj)
    {
        obj.SetActive(false);
    }
}
