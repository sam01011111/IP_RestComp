using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTableOrder : MonoBehaviour {

    public GameObject content;

    public void deleteTableOrder()
    {
        int childCount = content.gameObject.transform.childCount;
        for (int i = 1; i < childCount; i++)
        {
            GameObject.Destroy(content.transform.GetChild(i).gameObject);
        }
    }

    public void deleteSingleDish()
    {
        GameObject.Destroy(this.transform.parent.gameObject);
    }
}
