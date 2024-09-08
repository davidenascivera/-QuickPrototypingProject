using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class InviaDati : MonoBehaviour
{
    public string url;

    [SerializeField] private Slider _slider1;
    [SerializeField] private Slider _slider2;
    [SerializeField] private Slider _slider3;

    private string Valore1 = "0";
    private string Valore2 = "0";
    private string Valore3 = "0";

    private string Richiesta1;


    public void open()
    {

        //Debug.Log(Richiesta1);
        
        
        string Pacchetto1 = Valore1.PadLeft(3, '0'); //in questa parte prendo il valore dello slider e lo riempio di 0 per arrivare a 3 cifre
        string Pacchetto2 = Valore2.PadLeft(3, '0');
        string Pacchetto3 = Valore3.PadLeft(3, '0');

        string Richiesta1 = url + Pacchetto1 + Pacchetto2 + Pacchetto3; //mi creo la stringa finale andando a sommare tutti i 3 i valori da 3 cifre

        Debug.Log(Richiesta1);
        //Debug.Log(Valore2);
        StartCoroutine(GetRequest(Richiesta1)); //apro il link che ho appena creato con la classe definita sotto

    }
    void Start()
    {
        _slider1.onValueChanged.AddListener((v) => {        //leggo il valore dello slider usando questo listener 
            Valore1 = v.ToString("0");
            //Debug.Log(Valore1);
            open();
        });

        _slider2.onValueChanged.AddListener((v) =>
        {
            Valore2 = v.ToString("0");
            open();
            //Debug.Log(ValoreA);
        });
        _slider3.onValueChanged.AddListener((v) =>
        {
            Valore3 = v.ToString("0");
            open();
            //Debug.Log(ValoreA);
        });
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