using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelBehaviour : MonoBehaviour {

    public GameObject content;
    public Text loggedInAs;
    public ToggleChange script;

    public void onHelperButtonClicked()
    {
        loggedInAs.text = "Aushilfe";

        ToggleChange.helper = true;
        int childCount = content.gameObject.transform.childCount;

        
        
        if (childCount>1)
        {
            for(int i = 1; i<childCount; i++)
            {
                if (content.transform.GetChild(i).GetChild(2).gameObject.activeSelf == true)
                {
                    content.transform.GetChild(i).gameObject.SetActive(false);
                };
            }
        }

        script.setListener();
    }

    public void onEmployeeButtonClicked()
    {
        loggedInAs.text = "Angestellter";

        ToggleChange.helper = false;
        int childCount = content.gameObject.transform.childCount;

        

        if (childCount > 1)
        {
            for (int i = 1; i < childCount; i++)
            {
                if (content.transform.GetChild(i).gameObject.activeSelf == false)
                {
                    content.transform.GetChild(i).gameObject.SetActive(true);
                    content.transform.GetChild(i).GetChild(2).gameObject.SetActive(true);
                };
            }
        }

        script.setListener();
    }
}
