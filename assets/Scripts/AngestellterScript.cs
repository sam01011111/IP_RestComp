using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AngestellterScript : MonoBehaviour {

    public GameObject arCamera;
    public Camera uiCamera;
    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            arCamera.gameObject.SetActive(false);
            target.gameObject.SetActive(false);
            uiCamera.enabled = true;
        }
    }
}
