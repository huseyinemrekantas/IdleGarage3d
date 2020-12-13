using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangarsPanel : MonoBehaviour
{
    public GameObject panelHangars;
    private void OnMouseDown()
    {
        panelHangars.SetActive(true);
    }
}
