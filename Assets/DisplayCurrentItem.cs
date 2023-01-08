using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCurrentItem : MonoBehaviour
{

    public TMP_Text currentItemText;
    public TMP_Text itemtofind;
    public int currentNumber;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        string itemText = manager.GetComponent<DSAManager>().itemToFind.ToString();
        itemtofind.text = $"Item To Find: {itemText}";

        currentNumber = 0;
        currentItemText.text = $"Current Item: {currentNumber.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
        currentItemText.text = $"Current Item: {currentNumber.ToString()}";
    }
}
