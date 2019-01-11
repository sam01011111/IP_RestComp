using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderScrollViewScript : MonoBehaviour {
    private Text itemName;
    private Toggle toggle;
    private bool selected = false;

    public void addItem(Dropdown dropDown)
    {
        itemName = dropDown.captionText;
        if (!(itemName.text == "Getränke"))
        {
            //Instantiate(toggle);
            //toggle.GetComponentInChildren<Text>().text = itemName.text;
            //toggle.transform.SetParent(gameObject.transform, false);
            GameObject.FindGameObjectWithTag("MenuPanel").SetActive(false);
            this.transform.parent.gameObject.SetActive(true);
        }

    }

    void Update()
    {

    }
}
