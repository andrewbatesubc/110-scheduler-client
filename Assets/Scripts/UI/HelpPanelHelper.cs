using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanelHelper : MonoBehaviour {

    public GameObject panel;

    void Awake() {
        if (PlayerPrefs.GetInt("hasBeenHelped") != 1) {
            panel.SetActive(true);
        }
    }

    public void HandleHasBeenHelped() {
        PlayerPrefs.SetInt("hasBeenHelped", 1);
    }
}
