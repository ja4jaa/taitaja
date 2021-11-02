using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class matikka : MonoBehaviour
{
    private int first;
    private int second;
    private int sum;
    private int a;
    private int b;
    private int c;
    private int d;
    private int ran;

    private int count = 0;
    private int oikein = 0;

    public TextMeshProUGUI atext;
    public TextMeshProUGUI btext;
    public TextMeshProUGUI ctext;
    public TextMeshProUGUI dtext;
    public TextMeshProUGUI sumtext;

    public Image backA;
    public Image backB;
    public Image backC;
    public Image backD;

    private bool clicked = false;

    public GameObject loppuruutu;
    public TextMeshProUGUI loppuTeksti;
    public GameObject t�hti1;
    public GameObject t�hti2;
    public GameObject t�hti3;

    void Start()
    {
        
        if(count == 5)
        {
            loppuruutu.SetActive(true);
            loppuTeksti.text = "Sin� vastasit oikein " + oikein + "/" + 5 + " kysymyksist�.";

            if (oikein == 5)
            {
                t�hti1.SetActive(true);
                t�hti2.SetActive(true);
                t�hti3.SetActive(true);
            }
            else if (oikein >= 3)
            {
                t�hti1.SetActive(true);
                t�hti2.SetActive(true);
            }
            else if (oikein >= 1)
            {
                t�hti1.SetActive(true);
            }
        }
        clicked = false;
        first = Random.Range(1, 26);
        second = Random.Range(1, 26);
        ran = Random.Range(1, 5);
        sum = first + second;

        random();
        
        sumtext.text = "Paljonko on: " + first + "+" + second;
        atext.text = "A) " + a.ToString();
        btext.text = "B) " + b.ToString();
        ctext.text = "C) " + c.ToString();
        dtext.text = "D) " + d.ToString();

        backA.color = Color.HSVToRGB(188 / 360f, 0.33f, 1f);
        backB.color = Color.HSVToRGB(188 / 360f, 0.33f, 1f);
        backC.color = Color.HSVToRGB(188 / 360f, 0.33f, 1f);
        backD.color = Color.HSVToRGB(188 / 360f, 0.33f, 1f);

        count++;
    }

    void random()
    {
        if (ran == 1)
        {
            a = sum;
            b = sum - Random.Range(1, 4);
            c = sum + Random.Range(1, 5);
            d = sum - Random.Range(4, 7);
        }
        else if (ran == 2)
        {
            b = sum;
            a = sum - Random.Range(1, 4);
            c = sum + Random.Range(1, 5);
            d = sum - Random.Range(4, 7);
        }
        else if (ran == 3)
        {
            c = sum;
            a = sum - Random.Range(1, 5);
            b = sum + Random.Range(1, 5);
            d = sum + Random.Range(4, 7);
        }
        else
        {
            d = sum;
            a = sum + Random.Range(1, 4);
            b = sum - Random.Range(1, 5);
            c = sum + Random.Range(4, 7);
        }
    }

    public void AButton()
    {
        if (!clicked)
        {
            if (ran == 1)
            {
                backA.color = Color.green;
                oikein++;
                Invoke("Start", 2);
            }
            else
            {
                backA.color = Color.red;
                Invoke("Start", 2);
            }
            clicked = true;
        }
    }
    public void BButton()
    {
        if (!clicked)
        {
            if (ran == 2)
            {
                backB.color = Color.green;
                oikein++;
                Invoke("Start", 2);
            }
            else
            {
                backB.color = Color.red;
                Invoke("Start", 2);
            }
            clicked = true;
        }
    }
    public void CButton()
    {
        if (!clicked)
        {
            if (ran == 3)
            {
                backC.color = Color.green;
                oikein++;
                Invoke("Start", 2);
            }
            else
            {
                backC.color = Color.red;
                Invoke("Start", 2);
            }
            clicked = true;
        }
    }
    public void DButton()
    {
        if (!clicked)
        {
            if (ran == 4)
            {
                backD.color = Color.green;
                oikein++;
                Invoke("Start", 2);
            }
            else
            {
                backD.color = Color.red;
                Invoke("Start", 2);
            }
            clicked = true;
        }
    }
}
