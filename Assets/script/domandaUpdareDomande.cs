using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    public int count;
    public void play()
    {
        TestoDomanda1.text = primaDomanda.domanda1;
        TestoRispostaB.text = RispostaB.testoRispostaB;
        TestoRispostaA.text = RispostaA.testoRispostaA;
    }
    void Start()
    {
        play();
    }
    public void rispostaA()
    {
        economia = economia + primaDomanda.variazioneEconomiaA;
        salute = salute - primaDomanda.variazioneSaluteA;
        ambiente = ambiente + primaDomanda.variazioneAmbienteA;
        count++;
        if (count == 15)
        {
            Debug.Log("question limit reached");
            AsyncOperation operazione = SceneManager.LoadSceneAsync(0);
        }
    }
    public void rispostaB()
    {
        economia = economia - primaDomanda.variazioneEconomiaB;
        salute = salute + primaDomanda.variazioneSaluteB;
        ambiente = ambiente - primaDomanda.variazioneAmbienteB;
        count++;

    }
}
