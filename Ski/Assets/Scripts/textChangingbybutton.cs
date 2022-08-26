using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textChangingbybutton : MonoBehaviour
{
    Text textField;
    Text buttonTwo;
    int number1;
    int number2;

    void Start()
    {
        textField = GameObject.Find("Amount").GetComponent<Text>();
        buttonTwo = GameObject.Find("Mermi2").GetComponent<Text>();
        

    }
        public void changeText()
    {
        number1 += 10;
        number2 += 20;

        buttonTwo.text = "" + number1;
        textField.text = "" + number2;
    }


  
}
