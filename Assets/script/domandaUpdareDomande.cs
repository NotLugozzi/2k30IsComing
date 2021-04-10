using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class domandaUpdareDomande : MonoBehaviour
{
    public domandaData primaDomanda;
    public domandaData RispostaA;
    public domandaData RispostaB;
    public Text TestoDomanda1;
    public Text TestoRispostaA;
    public Text TestoRispostaB;
    public int economia;
    public int ambiente;
    public int salute;
    public int energia;
    private void Start()
    {
        TestoDomanda1.text = primaDomanda.domanda1;
        TestoRispostaA.text = RispostaA.testoRispostaA;
        TestoRispostaB.text = RispostaB.testoRispostaB;
    }
    public void rispostaA()
    {
        economia = economia + primaDomanda.variazioneEconomiaA;
        salute = salute - primaDomanda.variazioneSaluteA;
        ambiente = ambiente + primaDomanda.variazioneAmbienteA;
    }
    public void rispostaB()
    {
        economia = economia - primaDomanda.variazioneEconomiaB;
        salute = salute + primaDomanda.variazioneSaluteB;
        ambiente = ambiente - primaDomanda.variazioneAmbienteB;

    }
}
