using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditDeckController : MonoBehaviour {

    public GameObject template;

	// Use this for initialization
	void Start () {
        setupOwnedCards();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void setupOwnedCards()
    {
        GameObject tmp = GameObject.Find("OwnedScrollContent");
        int lastY = 0;

        for(int i = 0; i < 10; i++)
        {
            GameObject card = Instantiate(template, tmp.transform);
            card.transform.localPosition = new Vector3(0, (-30 + lastY));
            lastY = (int)card.transform.localPosition.y;
        }

        if(lastY < -260)
        {
            RectTransform rt = tmp.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, (lastY * -1) + 30 );
        }

    }
}
