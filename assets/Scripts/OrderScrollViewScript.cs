using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OrderScrollViewScript : MonoBehaviour {
    private Text itemName;
    public GameObject toggle;
    private bool selected = false;
    private string selectedOption;
    private Text toolTip;

    public void addItem(Dropdown dropDown)
    {
        itemName = dropDown.captionText;
        Debug.Log("test");
        if (!(itemName.text == "Getränke") && !(itemName.text == "Gerichte") && !(itemName.text == "Nachspeisen"))
        {
            GameObject newToggle = Instantiate(toggle) as GameObject;
            newToggle.GetComponentInChildren<Text>().text = "- " + itemName.text;
            newToggle.SetActive(true);
            newToggle.transform.SetParent(gameObject.transform.GetChild(0).GetChild(0), false);
            //toggle.GetComponentInChildren<Text>().text = itemName.text;
            //toggle.transform.SetParent(gameObject.transform, false);
            //GameObject.FindGameObjectWithTag("MenuPanel").SetActive(false);
            //this.transform.parent.gameObject.SetActive(true);
            selectedOption = dropDown.captionText.text;
            dropDown.value = 0;
            Debug.Log(selectedOption);
            dropDown.Hide();
        }

    }

    public void showToolTip(Text toolTip)
    {
        Debug.Log("showtooltip-methode aufgerufen mit " + selectedOption);
        this.toolTip = toolTip;
        if (!(selectedOption == "Getränke") && !(selectedOption == "Gerichte") && !(selectedOption == "Nachspeisen"))
        {
            Debug.Log("before showToolTip....");
            toolTip.text = selectedOption + " hinzugefügt";
            toolTip.gameObject.SetActive(true);
            if (this.IsInvoking())
            {
                Debug.Log("canceling invoke");
                this.CancelInvoke();
            }
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
