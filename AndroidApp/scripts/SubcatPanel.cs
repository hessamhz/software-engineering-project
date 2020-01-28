using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SubcatPanel : MonoBehaviour {

	private string catName;

	public GameObject SubcatPanelgo;
	public List<Button> subcats;
	// Use this for initialization
	public void OnCatSelect(){
		int i = 0;
		catName = EventSystem.current.currentSelectedGameObject.name;
		SubcatPanelgo.SetActive (true);
		switch (catName) {
		case "Repairment":
			for (i = 0; i < 3; i++) {
				subcats [i].GetComponentInChildren<Text> ().text = "This is Subcat " + i;
			}
			break;
		}
	}

	public void onSubCatSelected(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (2);
	}

	void Update(){
	
		if (Input.GetKey (KeyCode.Escape)) {
			SubcatPanelgo.SetActive (false);
		}
	}
}
