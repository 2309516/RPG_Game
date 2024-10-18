using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DiceNS
{
    public class DiceRoller : MonoBehaviour
{ 
    public TMP_InputField dice6ResultText;
    public TMP_InputField dice12ResultText;
    public TMP_InputField dice20ResultText;

    public Button roll;

    
    void Start()
    {
        roll.onClick.AddListener(RollDice);
    }

    
    public void RollDice()
    {
        int dice6Result = RollDice(6);
        int dice12Result = RollDice(12);
        int dice20Result = RollDice(20);

        dice6ResultText.text = "6 Sided Dice Roll: " + dice6Result;
        dice12ResultText.text = "12 Sided Dice Roll: " + dice12Result;
        dice20ResultText.text = "20 Sided Dice Roll: " + dice20Result;
    }

    private int RollDice(int sides)
    {
        return Random.Range(1, sides+1);
    }
}
}


