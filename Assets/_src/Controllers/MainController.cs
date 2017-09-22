using PoliticalSimulatorCore.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private static UserProfile currentUserProfile;

    public static UserProfile CurrentUserProfile
    {
        get { return currentUserProfile; }
        set { currentUserProfile = value; }
    }
}
