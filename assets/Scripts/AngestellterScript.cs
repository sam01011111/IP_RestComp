using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AngestellterScript : MonoBehaviour {

    public GameObject content;
    //public GameObject viewPort;

    // Use this for initialization
    void Start () {
        Debug.Log("ENTERED START-METHOD");
        Debug.Log(DataScript.getContent());
        if (!(DataScript.content==null))
        {
            Debug.Log("set content --> datascript content");
            content = DataScript.getContent();
        } else
        {
            Debug.Log("content null");
        }
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("ENTERED UPDATE-METHOD");
        if (!(content == null))
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("datascript content --> content");
                DataScript.setContent(content);
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
            }    
        }
    }

    void Awake()
    {

    }
}
