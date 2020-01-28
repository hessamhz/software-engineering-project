using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefineTask : MonoBehaviour {
	public GameObject newTaskPanel;
	public List<InputField> inputsFields;
	public List<Text> result;
	public Image offer;
	public Image Definition;
	public GameObject offerPanel;

	public void onPanelTouched(){
		newTaskPanel.SetActive (false);
	}

	public void onSubminClicked(){
		for (int i = 0; i < inputsFields.Count; i++) {
			result [i].text = inputsFields [i].text;
		}
		result[6].text = "InProgress...";
		result[7].text = "Waiting for offer...";
		for (int i = 0; i < inputsFields.Count; i++) {
			inputsFields[i].text = "";
		}
		newTaskPanel.SetActive (true);
		offer.GetComponent<Image> ().color = Definition.GetComponent<Image> ().color;
		offerPanel.SetActive (false);
	}


}
