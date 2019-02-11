using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSetting : MonoBehaviour {
    private Toggle toggle;
	// Use this for initialization
	void Start () {
        toggle = GetComponent<Toggle>();

		if(ToggleChange.helper == true)
        {
            toggle.onValueChanged.AddListener(delegate
            {
                helperToggleValueChanged(toggle);
            });
        } else {
            toggle.onValueChanged.AddListener(delegate
            {
                employeeToggleValueChanged(toggle);
            });
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
