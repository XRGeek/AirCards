using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutController : MonoBehaviour
{
    public GameObject[] objects;
    public void SetObjectState(bool state)
    {
        foreach (GameObject gb in objects)
        {
            gb.SetActive(state);
        }
    }
}
