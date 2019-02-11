using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChange : MonoBehaviour {
    private Toggle toggle;
    public static bool helper = false;
    private GameObject content;
    private List<Toggle> toggleList;

	// Use this for initialization
	public void setListener () {
        Debug.Log("-------- SET LISTENER METHOD");

        toggleList = new List<Toggle>();
        content = this.gameObject;
        int childCount = content.gameObject.transform.childCount;
        for(int i =0; i < childCount; i++)
        {
            toggleList.Add(content.transform.GetChild(i).gameObject.GetComponent<Toggle>());
        }

        if (helper)
        {
            Debug.Log("-------- SET LISTENER FOR HELPER");
            for (int i = 1; i < childCount; i++)
            {
                toggleList[i].onValueChanged.RemoveAllListeners();

                Debug.Log("-------- SET LISTENER FOR " + (i + 1) + ". TOGGLE: " + toggleList[i].GetComponentInChildren<Text>().text);

                int temp = i;
                toggleList[i].onValueChanged.AddListener(delegate
                {
                    helperToggleValueChanged(toggleList[temp]);
                });
            }
        } else {
            Debug.Log("-------- SET LISTENER FOR EMPLOYEE");
            for (int i = 1; i < childCount; i++)
            {
                toggleList[i].onValueChanged.RemoveAllListeners();

                Debug.Log("-------- SET LISTENER FOR " + (i + 1) + ". TOGGLE: " + toggleList[i].GetComponentInChildren<Text>().text);

                int temp = i;
                toggleList[i].onValueChanged.AddListener(delegate
                {
                    Debug.Log(temp);
                    employeeToggleValueChanged(toggleList[temp]);
                    Debug.Log(toggleList.Count);
                });
            }
        }
    }

    void helperToggleValueChanged(Toggle change)
    {
        Debug.Log("------- DEACTIVATE TOGGLE: " + change.GetComponentInChildren<Text>().text);
        
        change.gameObject.SetActive(false);
    }

    void employeeToggleValueChanged(Toggle change)
    {
        Debug.Log("------- ACTIVATE CHECKMARK: " + change.GetComponentInChildren<Text>().text);
        change.gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }
}
