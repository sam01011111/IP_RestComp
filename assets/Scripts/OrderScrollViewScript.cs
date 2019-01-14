using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OrderScrollViewScript : MonoBehaviour {
    private Text itemName;
    private Toggle toggle;
    private bool selected = false;
    private string selectedOption;
    private Text toolTip;

    public void addItem(Dropdown dropDown)
    {
        itemName = dropDown.captionText;
        Debug.Log("test");
        if (!(itemName.text == "Getränke"))
        {
            selectedOption = dropDown.captionText.text;
            //Instantiate(toggle);
            //toggle.GetComponentInChildren<Text>().text = itemName.text;
            //toggle.transform.SetParent(gameObject.transform, false);
            //GameObject.FindGameObjectWithTag("MenuPanel").SetActive(false);
            //this.transform.parent.gameObject.SetActive(true);
            Debug.Log("before 1 ....");
            selectedOption = dropDown.captionText.text;
            Debug.Log("before 2....");
            dropDown.value = 0;
            Debug.Log("before 4.... mit " + selectedOption);
            dropDown.Hide();
        }

    }

    public void showToolTip(Text toolTip)
    {
        Debug.Log("methode aufgerufen mit " + selectedOption);
        this.toolTip = toolTip;
        if (!(selectedOption == "Getränke"))
        {
            Debug.Log("before showToolTip....");
            toolTip.text = selectedOption + " hinzugefügt";
            toolTip.gameObject.SetActive(true);
            Invoke("deactivateText", 2);
        }
        
    }


    public void deactivateText()
    {
        toolTip.gameObject.SetActive(false);
    }

    void Update()
    {

    }
}
