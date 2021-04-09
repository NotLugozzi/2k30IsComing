using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class domandaUpdareDomande : MonoBehaviour
{
    public domandaData primaDomanda;
    public Text TestoDescrizione;
    public int soldi;
    private void Start()
    {
        TestoDescrizione.text = primaDomanda.dercrizione;
    }
    public void rispostaA()
    {
        soldi = soldi - primaDomanda.variazioneSoldiA;
    }
}
