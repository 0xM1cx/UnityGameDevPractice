using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DSAManager : MonoBehaviour
{

    public List<GameObject> Positions = new List<GameObject>(); // List han mga possible positions han mga bars;
    public List<GameObject> Bars = new List<GameObject>(); // list han mga bars

    public GameObject CurrentItemTextLocation;
    public int itemToFind;
    
    [Range(0.0f, 5.0f)]
    public float searchSpeed;
    public GameObject itemFound;
    public Color currentItem = new Color(0, 41, 255, 255);
    public Color defaultColor = new Color(255,255,255,255);
    // amo ine an value na mag determine kun gin click ba or wry an linear search button
    public bool checkedLinearSearch = false; 
    public GameObject tempBox; 
    public TextMesh theText; 
    public int RealTimeCurrentNumber = 0;
    // check kun gin click han user an linear search button. 
    // kun wry gin click then dire mag run an linear search pag click han simulation button
    public void isChecked()
    {
        checkedLinearSearch = true;
    }
    
    private bool isItemFound = false;
    // This function, if called, will perfrom linear search on the bars collections
    public IEnumerator LinearSearch()
    {  
        tempBox = (GameObject)Instantiate(itemFound, new Vector3(28.6f,30.7f,0), Quaternion.identity);
        theText = tempBox.transform.GetComponent<TextMesh>();
        for(int i = 0; i<Bars.Count; i++)
        {
            RealTimeCurrentNumber = i;
            CurrentItemTextLocation.GetComponent<DisplayCurrentItem>().currentNumber = i;
            Bars[i].GetComponent<SpriteRenderer>().color = currentItem;
            if(i == itemToFind){
                Bars[i].GetComponent<SpriteRenderer>().color = currentItem;
                isItemFound = true;
                theText.text = "ITEM FOUND";
                break;

            }
            yield return new WaitForSeconds(searchSpeed);
            Bars[i].GetComponent<SpriteRenderer>().color = defaultColor;
        }
        if(isItemFound == false)
        {
            theText.text = "ITEM NOT IN LIST";
        }
        
    }
    public void restart()
    {
        theText.text = " ";   
        Bars[RealTimeCurrentNumber].GetComponent<SpriteRenderer>().color = defaultColor;
        StartCoroutine(LinearSearch());
    }
    // Ine na function kay mag check kun nano na functions an been checked and which to run based on those boolean values
    public void Simulate()
    {
        if(checkedLinearSearch)
        {
            StartCoroutine(LinearSearch());
        }else{
            Debug.Log("Linear Search Was Not Clicked");
        }
    }


    // This function will run once when the program starts
    void Start()
    {
        
        for(int i = 1; i <= 32; i++)
        {
            Positions.Add(GameObject.Find($"Position {i}"));
            Bars.Add(GameObject.Find($"Bar {i}"));
        }

        
    }

    public void OnButtonPress()
    {
        Simulate();
    }


}
