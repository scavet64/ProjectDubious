using PoliticalSimulatorCore.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditDeckController : MonoBehaviour {

    public static EditDeckController Instance { get; set; }

    public GameObject template;
    public Card CurrentSelectedCard { get; set; }

    public GameObject SelectedCardPanel;
    private Image selectedCardPanelImage;

    private const string OWNEDCARDSPANEL = "OwnedScrollContent";
    private const string INDECKPANEL = "InDeckContent";


    // Use this for initialization
    void Start () {
        selectedCardPanelImage = SelectedCardPanel.GetComponent<Image>();
        SetupOwnedCards();
        SetupCardsInDeck();
        Instance = this;
    }

    public void AddCardToDeck()
    {
        if (MainController.CurrentUserProfile.CurrentDeck.addCard(CurrentSelectedCard))
        {
            AddCardToGuiList(CurrentSelectedCard, GameObject.Find(INDECKPANEL));

            //remove from available card list maybe
            GameObject tmp = FindGameObjectFromList(GameObject.Find(OWNEDCARDSPANEL), CurrentSelectedCard);
            Destroy(tmp);
        }
        else
        {
            //Display error
        }
        
    }

    public void RemoveCardFromDeck()
    {
        if (MainController.CurrentUserProfile.CurrentDeck.removeCard(CurrentSelectedCard))
        {
            //remove from deck gui and add back to available cards
            GameObject tmp = FindGameObjectFromList(GameObject.Find(INDECKPANEL), CurrentSelectedCard);
            Destroy(tmp);
        }
        else
        {
            //display error
        }
    }

    public void CardWasSelected(Card card)
    {
        CurrentSelectedCard = card;
        Sprite sp = Resources.Load(card.ImageFilePath, typeof(Sprite)) as Sprite;
        Debug.Log(sp);
        selectedCardPanelImage.sprite = sp;
    }

    private void SetupOwnedCards()
    {
        List<Card> cards = MainController.CurrentUserProfile.CollectedCards;
        GameObject tmp = GameObject.Find(OWNEDCARDSPANEL);

        for (int i = 0; i < cards.Count; i++)
        {
            AddCardToGuiList(cards[i], tmp);
        }
    }

    private void SetupCardsInDeck()
    {
        List<Card> cards = MainController.CurrentUserProfile.CurrentDeck.CardList;
        GameObject tmp = GameObject.Find(INDECKPANEL);

        for (int i = 0; i < cards.Count; i++)
        {
            AddCardToGuiList(cards[i], tmp);
        }
    }

    private void AddCardToGuiList(Card card, GameObject parentElement)
    {
        GameObject cardGO = Instantiate(template, parentElement.transform);

        cardGO.GetComponent<EditDeckElement>().CardThatWeRepresent = card;
        cardGO.GetComponentInChildren<Text>().text = card.Name;
    }

    private GameObject FindGameObjectFromList(GameObject listToCheck, Card cardToFind)
    {
        foreach (Transform childTrans in listToCheck.transform)
        {
            EditDeckElement ede = childTrans.GetComponent<EditDeckElement>();
            if (ede.CardThatWeRepresent.Equals(cardToFind))
            {
                return childTrans.gameObject;
            }
        }

        return null;
    }
}
