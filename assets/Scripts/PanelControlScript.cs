using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControlScript : MonoBehaviour {

    public GameObject panel;

    public void openPanel()
    {
        if(panel != null)
        {
            this.transform.parent.gameObject.SetActive(false);
            panel.SetActive(true);
        }
    }

    public void closePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}
