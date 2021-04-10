using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class domandaUpdareDomande : MonoBehaviour
{
    public domandaData primaDomanda;
    public Text TestoDescrizione;
    public int economia;
    public int ambiente;
    public int salute;
    public int energia;
    private void Start()
    {
        TestoDescrizione.text = primaDomanda.domanda1;
    }
    public void rispostaA()
    {
        economia = economia + primaDomanda.variazioneEconomiaA;
        salute = salute - primaDomanda.variazioneSaluteA;
        ambiente = ambiente + primaDomanda.variazioneAmbienteA;
    }
    public void rispostaB()
    {
        
    }
}
