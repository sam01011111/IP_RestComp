using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScript : MonoBehaviour {
    public static GameObject content;
    private static bool instantiated;
	// Use this for initialization
	void Start () {
        content = new GameObject();
        DontDestroyOnLoad(this.gameObject);

        if (!instantiated)
        {
            instantiated = true;
        }
        else
        {
            Object.Destroy(this.gameObject);
        }
    }
	
    public static GameObject getContent()
    {
        return content;
    }

    public static void setContent(GameObject content2)
    {
        content = Instantiate(content2);
        Debug.Log(content);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
