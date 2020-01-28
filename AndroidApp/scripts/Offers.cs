using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Offers : MonoBehaviour {
	public GameObject offerPanel;
	public GameObject paymentPanel;

	public Image offer;
	public Image payment;

	public Text status;
	public void onOfferSelected(){
		status.text = "Payment";
		payment.GetComponent<Image> ().color = offer.GetComponent<Image> ().color;
		paymentPanel.SetActive (false);
		offerPanel.SetActive (true);
	}
}
