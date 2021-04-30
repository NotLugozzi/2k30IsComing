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
    public Text TestoEconomia;
    public int economia;
    public int ambiente;
    public int salute;
    public int energia;
    public int count;
    public void play()
    {
        TestoDomanda1.text = primaDomanda.domanda1;
        TestoRispostaB.text = RispostaB.testoRispostaB1;
        TestoRispostaA.text = RispostaA.testoRispostaA1;
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
        if (count == 14)
        {
            Debug.Log("question limit reached");
            AsyncOperation operazione = SceneManager.LoadSceneAsync(3);
        }
        if (count == 1)
        {
            TestoDomanda1.text = primaDomanda.domanda2;
            TestoRispostaB.text = RispostaB.testoRispostaB2;
            TestoRispostaA.text = RispostaA.testoRispostaA2;

            economia = economia - 10;
            salute = salute + 10;
            ambiente = ambiente - 10;
        }
        else if (count == 2)
        {
            TestoDomanda1.text = primaDomanda.domanda3;
            TestoRispostaB.text = RispostaB.testoRispostaB3;
            TestoRispostaA.text = RispostaA.testoRispostaA3;
        }
        else if (count == 3)
        {
            TestoDomanda1.text = primaDomanda.domanda4;
            TestoRispostaB.text = RispostaB.testoRispostaB4;
            TestoRispostaA.text = RispostaA.testoRispostaA4;
        }
        else if (count == 4)
        {
            TestoDomanda1.text = primaDomanda.domanda5;
            TestoRispostaB.text = RispostaB.testoRispostaB5;
            TestoRispostaA.text = RispostaA.testoRispostaA5;
        }
        else if (count == 5)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB6;
            TestoRispostaA.text = RispostaA.testoRispostaA6;
        }
        else if (count == 6)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB7;
            TestoRispostaA.text = RispostaA.testoRispostaA7;
        }
        else if (count == 7)
        {
            TestoDomanda1.text = primaDomanda.domanda8;
            TestoRispostaB.text = RispostaB.testoRispostaB8;
            TestoRispostaA.text = RispostaA.testoRispostaA8;
        }
        else if (count == 8)
        {
            TestoDomanda1.text = primaDomanda.domanda9;
            TestoRispostaB.text = RispostaB.testoRispostaB9;
            TestoRispostaA.text = RispostaA.testoRispostaA9;
        }
        else if (count == 9)
        {
            TestoDomanda1.text = primaDomanda.domanda10;
            TestoRispostaB.text = RispostaB.testoRispostaB10;
            TestoRispostaA.text = RispostaA.testoRispostaA10;
        }
        else if (count == 10)
        {
            TestoDomanda1.text = primaDomanda.domanda11;
            TestoRispostaB.text = RispostaB.testoRispostaB11;
            TestoRispostaA.text = RispostaA.testoRispostaA11;
        }
        else if (count == 11)
        {
            TestoDomanda1.text = primaDomanda.domanda12;
            TestoRispostaB.text = RispostaB.testoRispostaB12;
            TestoRispostaA.text = RispostaA.testoRispostaA12;
        }
        else if (count == 12)
        {
            TestoDomanda1.text = primaDomanda.domanda13;
            TestoRispostaB.text = RispostaB.testoRispostaB13;
            TestoRispostaA.text = RispostaA.testoRispostaA13;
        }
        else if (count == 13)
        {
            TestoDomanda1.text = primaDomanda.domanda14;
            TestoRispostaB.text = RispostaB.testoRispostaB14;
            TestoRispostaA.text = RispostaA.testoRispostaA14;
        }
        else if (count == 14)
        {
            TestoDomanda1.text = primaDomanda.domanda15;
            TestoRispostaB.text = RispostaB.testoRispostaB15;
            TestoRispostaA.text = RispostaA.testoRispostaA15;
        }
    }
    public void rispostaB()
    {
        economia = economia - primaDomanda.variazioneEconomiaB;
        salute = salute + primaDomanda.variazioneSaluteB;
        ambiente = ambiente - primaDomanda.variazioneAmbienteB;
        count++;
        if (count == 14)
        {
            Debug.Log("question limit reached");
            AsyncOperation operazione = SceneManager.LoadSceneAsync(3);
        }
        if (count == 1)
        {
            TestoDomanda1.text = primaDomanda.domanda2;
            TestoRispostaB.text = RispostaB.testoRispostaB2;
            TestoRispostaA.text = RispostaA.testoRispostaA2;
        }
        else if (count == 2)
        {
            TestoDomanda1.text = primaDomanda.domanda3;
            TestoRispostaB.text = RispostaB.testoRispostaB3;
            TestoRispostaA.text = RispostaA.testoRispostaA3;
        }
        else if (count == 3)
        {
            TestoDomanda1.text = primaDomanda.domanda4;
            TestoRispostaB.text = RispostaB.testoRispostaB4;
            TestoRispostaA.text = RispostaA.testoRispostaA4;
        }
        else if (count == 4)
        {
            TestoDomanda1.text = primaDomanda.domanda5;
            TestoRispostaB.text = RispostaB.testoRispostaB5;
            TestoRispostaA.text = RispostaA.testoRispostaA5;
        }
        else if (count == 5)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB6;
            TestoRispostaA.text = RispostaA.testoRispostaA6;
        }
        else if (count == 6)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB7;
            TestoRispostaA.text = RispostaA.testoRispostaA7;
        }
        else if (count == 7)
        {
            TestoDomanda1.text = primaDomanda.domanda8;
            TestoRispostaB.text = RispostaB.testoRispostaB8;
            TestoRispostaA.text = RispostaA.testoRispostaA8;
        }
        else if (count == 8)
        {
            TestoDomanda1.text = primaDomanda.domanda9;
            TestoRispostaB.text = RispostaB.testoRispostaB9;
            TestoRispostaA.text = RispostaA.testoRispostaA9;
        }
        else if (count == 9)
        {
            TestoDomanda1.text = primaDomanda.domanda10;
            TestoRispostaB.text = RispostaB.testoRispostaB10;
            TestoRispostaA.text = RispostaA.testoRispostaA10;
        }
        else if (count == 10)
        {
            TestoDomanda1.text = primaDomanda.domanda11;
            TestoRispostaB.text = RispostaB.testoRispostaB11;
            TestoRispostaA.text = RispostaA.testoRispostaA11;
        }
        else if (count == 11)
        {
            TestoDomanda1.text = primaDomanda.domanda12;
            TestoRispostaB.text = RispostaB.testoRispostaB12;
            TestoRispostaA.text = RispostaA.testoRispostaA12;
        }
        else if (count == 12)
        {
            TestoDomanda1.text = primaDomanda.domanda13;
            TestoRispostaB.text = RispostaB.testoRispostaB13;
            TestoRispostaA.text = RispostaA.testoRispostaA13;
        }
        else if (count == 13)
        {
            TestoDomanda1.text = primaDomanda.domanda14;
            TestoRispostaB.text = RispostaB.testoRispostaB14;
            TestoRispostaA.text = RispostaA.testoRispostaA14;
        }
        else if (count == 14)
        {
            TestoDomanda1.text = primaDomanda.domanda15;
            TestoRispostaB.text = RispostaB.testoRispostaB15;
            TestoRispostaA.text = RispostaA.testoRispostaA15;
        }
    }
    public void var()
    {
    
    }
}
