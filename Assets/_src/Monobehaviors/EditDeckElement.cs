using PoliticalSimulatorCore.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditDeckElement : MonoBehaviour {


    public Card CardThatWeRepresent { get; set; }

    public void Selected()
    {
        EditDeckController.Instance.CardWasSelected(CardThatWeRepresent);
    }
	
}
