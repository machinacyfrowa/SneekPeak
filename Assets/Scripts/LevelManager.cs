using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //czas do zakonczenia poziomu
    public float timeLeft = 90f;

    //elementy UI
    public GameObject timeCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozosta�ego na wykonanie poziomu
        //o czas, kt�ry min�� od ostaniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UI
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacj� interfejsu u�ytkownika

        timeCounter.GetComponent<TextMeshProUGUI>().text = "Pozosta�y czas:" + Mathf.Floor(timeLeft).ToString();
    }
}
