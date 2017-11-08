using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ToggleHelper : MonoBehaviour {

    private Toggle toggle;
    [SerializeField]
    private SelectionHandler selectionHandler;

    private void Awake() {
        toggle = GetComponent<Toggle>();
        //Set default selection behavior to be 'NotAvailable' when program starts
        selectionHandler.ToggleNotAvailable();
		LoadURL ();
    }

	private void LoadURL(){
		string path = System.Environment.CurrentDirectory + "/url.txt";
		string url = File.ReadAllText (path);
		if (url != null && url.Length > 0) {
			PlayerPrefs.SetString(Settings.URL_KEY, url);
		}
	}
    public void HandleToggleAvailable() {
        if (toggle.isOn) {
            selectionHandler.ToggleAvailable();
        }
    }

    public void HandleToggleNotAvailable() {
        if (toggle.isOn) {
            selectionHandler.ToggleNotAvailable();
        }
    }

    public void HandleTogglePreferNot() {
        if (toggle.isOn) {
            selectionHandler.TogglePreferNot();
        }
    }

}
