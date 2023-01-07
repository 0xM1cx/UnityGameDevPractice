using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSAManager : MonoBehaviour
{
    // public GameObject barOne;
    // public GameObject barTwo;
    
    // public GameObject barThree;
    // public GameObject barFour;
    // public GameObject barFive;
    // public GameObject barSix;
    // public GameObject barSeven;

    // public GameObject positionOne = GameObject.Find("Position 1");
    // public GameObject positionTwo = GameObject.Find("Position 2");
    // public GameObject positionThree = GameObject.Find("Position 3");
    // public GameObject positionFour = GameObject.Find("Position 4");
    // public GameObject positionFive = GameObject.Find("Position 5");
    // public GameObject positionSix = GameObject.Find("Position 6");
    // public GameObject positionSeven = GameObject.Find("Position 7");

    public List<GameObject> Positions = new List<GameObject>();
    public List<GameObject> Bars = new List<GameObject>();

    // void Start()
    // {
            
    //     Positions.Add(positionOne);
    //     Positions.Add(positionTwo);
    //     Positions.Add(positionThree);
    //     Positions.Add(positionFour);
    //     Positions.Add(positionFive);
    //     Positions.Add(positionSix);
    //     Positions.Add(positionSeven);

    //     Positions.Add(barOne);
    //     Positions.Add(barTwo);
    //     Positions.Add(barThree);
    //     Positions.Add(barFour);
    //     Positions.Add(barFive);
    //     Positions.Add(barSix);
    //     Positions.Add(barSeven);


    // }
    
    public void Simulate()
    {
        
    }

    void Start()
    {
        for(int i = 1; i <= 7; i++)
        {
            Positions.Add(GameObject.Find($"Position {i}"));
        }

        for(int b = 1; b <= 7; b++)
        {
            Bars.Add(GameObject.Find($"Bar {b}"));
        }

        
    }

    public void OnButtonPress()
    {
        Simulate();
    }


}
