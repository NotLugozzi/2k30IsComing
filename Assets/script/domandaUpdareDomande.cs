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
    public Text TestoAmbiente;
    public Text TestoEconomia;
    public Text Data;
    public int economia;
    public int ambiente;
    public int salute;
    public int energia;
    public int count;
    public int countData = 2000;

    public void play()
    {

        TestoDomanda1.text = primaDomanda.domanda1;
        TestoRispostaB.text = RispostaB.testoRispostaB1;
        TestoRispostaA.text = RispostaA.testoRispostaA1;
        TestoAmbiente.text = ambiente.ToString();
        Data.text = countData.ToString();
    }
    void Update()
    {
        Data.text = countData.ToString();
    }
    void Start()
    {
        play();
    }
    public void rispostaA()
    {
        if (count == 14)
        {
            Debug.Log("question limit reached");
            AsyncOperation operazione = SceneManager.LoadSceneAsync(3);
        }
        if (count == 0)
        {
            economia = economia + primaDomanda.variazioneEconomiaA;
            salute = salute - primaDomanda.variazioneSaluteA;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA;
            count++;
            countData = countData + 2;
        }
        else if (count == 1)
        {
            TestoDomanda1.text = primaDomanda.domanda2;
            TestoRispostaB.text = RispostaB.testoRispostaB2;
            TestoRispostaA.text = RispostaA.testoRispostaA2;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA2;
            salute = salute - primaDomanda.variazioneSaluteA2;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA2;
            count++;
        }
        else if (count == 2)
        {
            TestoDomanda1.text = primaDomanda.domanda3;
            TestoRispostaB.text = RispostaB.testoRispostaB3;
            TestoRispostaA.text = RispostaA.testoRispostaA3;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA3;
            salute = salute - primaDomanda.variazioneSaluteA3;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA3;
            count++;
        }
        else if (count == 3)
        {
            TestoDomanda1.text = primaDomanda.domanda4;
            TestoRispostaB.text = RispostaB.testoRispostaB4;
            TestoRispostaA.text = RispostaA.testoRispostaA4;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA4;
            salute = salute - primaDomanda.variazioneSaluteA4;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA4;
            count++;
        }
        else if (count == 4)
        {
            TestoDomanda1.text = primaDomanda.domanda5;
            TestoRispostaB.text = RispostaB.testoRispostaB5;
            TestoRispostaA.text = RispostaA.testoRispostaA5;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA5;
            salute = salute - primaDomanda.variazioneSaluteA5;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA5;
            count++;
        }
        else if (count == 5)
        {
            TestoDomanda1.text = primaDomanda.domanda6;
            TestoRispostaB.text = RispostaB.testoRispostaB6;
            TestoRispostaA.text = RispostaA.testoRispostaA6;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA6;
            salute = salute - primaDomanda.variazioneSaluteA6;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA6;
            count++;
        }
        else if (count == 6)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB7;
            TestoRispostaA.text = RispostaA.testoRispostaA7;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA7;
            salute = salute - primaDomanda.variazioneSaluteA7;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA7;
            count++;
        }
        else if (count == 7)
        {
            TestoDomanda1.text = primaDomanda.domanda8;
            TestoRispostaB.text = RispostaB.testoRispostaB8;
            TestoRispostaA.text = RispostaA.testoRispostaA8;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA8;
            salute = salute - primaDomanda.variazioneSaluteA8;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA8;
            count++;
        }
        else if (count == 8)
        {
            TestoDomanda1.text = primaDomanda.domanda9;
            TestoRispostaB.text = RispostaB.testoRispostaB9;
            TestoRispostaA.text = RispostaA.testoRispostaA9;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA9;
            salute = salute - primaDomanda.variazioneSaluteA9;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA9;
            count++;
        }
        else if (count == 9)
        {
            TestoDomanda1.text = primaDomanda.domanda10;
            TestoRispostaB.text = RispostaB.testoRispostaB10;
            TestoRispostaA.text = RispostaA.testoRispostaA10;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA10;
            salute = salute - primaDomanda.variazioneSaluteA10;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA10;
            count++;
        }
        else if (count == 10)
        {
            TestoDomanda1.text = primaDomanda.domanda11;
            TestoRispostaB.text = RispostaB.testoRispostaB11;
            TestoRispostaA.text = RispostaA.testoRispostaA11;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA11;
            salute = salute + primaDomanda.variazioneSaluteA11;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA11;
            count++;
        }
        else if (count == 11)
        {
            TestoDomanda1.text = primaDomanda.domanda12;
            TestoRispostaB.text = RispostaB.testoRispostaB12;
            TestoRispostaA.text = RispostaA.testoRispostaA12;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA12;
            salute = salute - primaDomanda.variazioneSaluteA12;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA12;
            count++;
        }
        else if (count == 12)
        {
            TestoDomanda1.text = primaDomanda.domanda13;
            TestoRispostaB.text = RispostaB.testoRispostaB13;
            TestoRispostaA.text = RispostaA.testoRispostaA13;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA13;
            salute = salute - primaDomanda.variazioneSaluteA13;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA13;
            count++;
        }
        else if (count == 13)
        {
            TestoDomanda1.text = primaDomanda.domanda14;
            TestoRispostaB.text = RispostaB.testoRispostaB14;
            TestoRispostaA.text = RispostaA.testoRispostaA14;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA14;
            salute = salute - primaDomanda.variazioneSaluteA14;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA14;
            count++;
        }
        else if (count == 14)
        {
            TestoDomanda1.text = primaDomanda.domanda15;
            TestoRispostaB.text = RispostaB.testoRispostaB15;
            TestoRispostaA.text = RispostaA.testoRispostaA15;
            countData = countData + 2;

            economia = economia + primaDomanda.variazioneEconomiaA15;
            salute = salute - primaDomanda.variazioneSaluteA15;
            ambiente = ambiente + primaDomanda.variazioneAmbienteA15;
            count++;
        }
    }
    public void rispostaB()
    {
        if (count == 14)
        {
            Debug.Log("question limit reached");
            AsyncOperation operazione = SceneManager.LoadSceneAsync(3);
        }
        if (count == 0)
        {
            economia = economia - primaDomanda.variazioneEconomiaB;
            salute = salute + primaDomanda.variazioneSaluteB;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB;
            count++;
            countData = countData + 2;
        }
        else if (count == 1)
        {
            TestoDomanda1.text = primaDomanda.domanda2;
            TestoRispostaB.text = RispostaB.testoRispostaB2;
            TestoRispostaA.text = RispostaA.testoRispostaA2;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB2;
            salute = salute + primaDomanda.variazioneSaluteB2;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB2;
            count++;
        }
        else if (count == 2)
        {
            TestoDomanda1.text = primaDomanda.domanda3;
            TestoRispostaB.text = RispostaB.testoRispostaB3;
            TestoRispostaA.text = RispostaA.testoRispostaA3;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB3;
            salute = salute + primaDomanda.variazioneSaluteB3;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB3;
            count++;
        }
        else if (count == 3)
        {
            TestoDomanda1.text = primaDomanda.domanda4;
            TestoRispostaB.text = RispostaB.testoRispostaB4;
            TestoRispostaA.text = RispostaA.testoRispostaA4;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB4;
            salute = salute + primaDomanda.variazioneSaluteB4;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB4;
            count++;
        }
        else if (count == 4)
        {
            TestoDomanda1.text = primaDomanda.domanda5;
            TestoRispostaB.text = RispostaB.testoRispostaB5;
            TestoRispostaA.text = RispostaA.testoRispostaA5;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB5;
            salute = salute + primaDomanda.variazioneSaluteB5;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB5;
            count++;
        }
        else if (count == 5)
        {
            TestoDomanda1.text = primaDomanda.domanda6;
            TestoRispostaB.text = RispostaB.testoRispostaB6;
            TestoRispostaA.text = RispostaA.testoRispostaA6;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB6;
            salute = salute + primaDomanda.variazioneSaluteB6;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB6;
            count++;
        }
        else if (count == 6)
        {
            TestoDomanda1.text = primaDomanda.domanda7;
            TestoRispostaB.text = RispostaB.testoRispostaB7;
            TestoRispostaA.text = RispostaA.testoRispostaA7;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB7;
            salute = salute + primaDomanda.variazioneSaluteB7;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB7;
            count++;
        }
        else if (count == 7)
        {
            TestoDomanda1.text = primaDomanda.domanda8;
            TestoRispostaB.text = RispostaB.testoRispostaB8;
            TestoRispostaA.text = RispostaA.testoRispostaA8;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB8;
            salute = salute + primaDomanda.variazioneSaluteB8;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB8;
            count++;
        }
        else if (count == 8)
        {
            TestoDomanda1.text = primaDomanda.domanda9;
            TestoRispostaB.text = RispostaB.testoRispostaB9;
            TestoRispostaA.text = RispostaA.testoRispostaA9;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB9;
            salute = salute + primaDomanda.variazioneSaluteB9;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB9;
            count++;
        }
        else if (count == 9)
        {
            TestoDomanda1.text = primaDomanda.domanda10;
            TestoRispostaB.text = RispostaB.testoRispostaB10;
            TestoRispostaA.text = RispostaA.testoRispostaA10;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB10;
            salute = salute + primaDomanda.variazioneSaluteB10;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB10;
            count++;
        }
        else if (count == 10)
        {
            TestoDomanda1.text = primaDomanda.domanda11;
            TestoRispostaB.text = RispostaB.testoRispostaB11;
            TestoRispostaA.text = RispostaA.testoRispostaA11;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB11;
            salute = salute - primaDomanda.variazioneSaluteB11;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB11;
            energia = energia - primaDomanda.variazioneEnergiaB11;
            count++;
        }
        else if (count == 11)
        {
            TestoDomanda1.text = primaDomanda.domanda12;
            TestoRispostaB.text = RispostaB.testoRispostaB12;
            TestoRispostaA.text = RispostaA.testoRispostaA12;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB12;
            salute = salute + primaDomanda.variazioneSaluteB12;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB12;
            count++;
        }
        else if (count == 12)
        {
            TestoDomanda1.text = primaDomanda.domanda13;
            TestoRispostaB.text = RispostaB.testoRispostaB13;
            TestoRispostaA.text = RispostaA.testoRispostaA13;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB13;
            salute = salute + primaDomanda.variazioneSaluteB13;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB13;
            count++;
        }
        else if (count == 13)
        {
            TestoDomanda1.text = primaDomanda.domanda14;
            TestoRispostaB.text = RispostaB.testoRispostaB14;
            TestoRispostaA.text = RispostaA.testoRispostaA14;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB14;
            salute = salute + primaDomanda.variazioneSaluteB14;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB14;
            count++;
        }
        else if (count == 14)
        {
            TestoDomanda1.text = primaDomanda.domanda15;
            TestoRispostaB.text = RispostaB.testoRispostaB15;
            TestoRispostaA.text = RispostaA.testoRispostaA15;
            countData = countData + 2;

            economia = economia - primaDomanda.variazioneEconomiaB15;
            salute = salute + primaDomanda.variazioneSaluteB15;
            ambiente = ambiente - primaDomanda.variazioneAmbienteB15;
            count++;
        }
    }
    public void var()
    {
    }
}
