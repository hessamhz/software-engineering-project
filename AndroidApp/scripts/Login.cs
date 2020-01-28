using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System;

public class Login : MonoBehaviour {
	
	private string UserName;
	private string Password;

	public InputField username;
	public InputField password;
	public Text err;

	public GameObject exitPanel;

//	private User user;
//	private ProfileManager profMan;
//	private Action<bool, string, User> userCallback;

	public void Navigate(){

		UserName = username.text;
		Password = password.text;
		if(UserName =="zeynab" && Password == "1376"){
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
		}else{
			err.gameObject.SetActive (true);
		}
//		profMan.login (UserName, Password, userCallback((true, "", getUser())=>{
//			//Save data
//			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
//		}));
	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			exitPanel.SetActive (true);
		}
	}

	public void onQuitSelected(){
		Application.Quit ();
	}

	public void onContinueSelected(){
		exitPanel.SetActive (false);
	}
}
