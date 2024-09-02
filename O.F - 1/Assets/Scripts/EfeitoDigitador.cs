using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class EfeitoDigitador : MonoBehaviour
{
    private TextMeshProUGUI componentTexto;
    private AudioSource _audioSource;
    private string mensagemOriginal;
    public bool imprimindo;

    private void Awake () 
    {

    }

    private void OnEnable () 
    {

    }

    private void OnDisable () 
    {
 
    }

    public ImprimirMensagem (string msg) 
    {

    }

    IEnumerator LetraPorLetra (string msg)
    {
        yield return null;
    }



}
