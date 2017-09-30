using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliticalSimulatorCore.Model
{
    public class AllCards
    {
        private static AllCards instance;
        private List<Card> allCards = new List<Card>();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.AllCards"/> class.
        /// </summary>
        private AllCards()
        {
            //initialize all cards here		
            //name,fatigue,chance,attack,health,type,CardImage,FieldImage
            //Charismatic Cards
            /*-1*/
            //allCards.Add(new Creature("Thonking", 2, 80, 1, 2, Type.CHARASMATIC, "Images\\CardImages\\2d4", "Images\\FieldImages\\hankField"));

            /*0*/
            allCards.Add(new Creature("Hank Hill", 2, 80, 1, 2, Type.CHARASMATIC, "Images\\CardImages\\hankCard", "Images\\FieldImages\\hankField"));
            /*1*/
            allCards.Add(new Creature("Billy Mays", 2, 90, 4, 2, Type.CHARASMATIC, "Images\\CardImages\\billyCard", "Images\\FieldImages\\BillyMaysField"));
            /*2*/
            allCards.Add(new Creature("Esteban Winsmore", 3, 90, 5, 3, Type.CHARASMATIC, "Images\\CardImages\\EstebanCard", "Images\\FieldImages\\EstebanField"));
            /*3*/
            allCards.Add(new Creature("Handsome Squidward", 5, 75, 5, 5, Type.CHARASMATIC, "Images\\CardImages\\HsquidCard", "Images\\FieldImages\\handsomeSquidwardField"));
            /*4*/
            allCards.Add(new RareCreature("Vladimir Putin", 7, 90, 7, 8, Type.CHARASMATIC, "Images\\CardImages\\VladimirPutinCard", "Images\\FieldImages\\VladPutinField"));
            /*5*/
            allCards.Add(new RareCreature("Based God", 2, 100, 4, 5, Type.CHARASMATIC, "Images\\CardImages\\lilBCard", "Images\\FieldImages\\basedGodField"));

            //Fighter Cards
            /*6*/
            allCards.Add(new Creature("Butch DeLoria", 2, 85, 3, 1, Type.FIGHTER, "Images\\CardImages\\tunnelCard", "Images\\FieldImages\\tunnelField"));
            /*7*/
            allCards.Add(new RareCreature("Champ", 3, 90, 3, 3, Type.FIGHTER, "Images\\CardImages\\champCard", "Images\\FieldImages\\champField"));
            /*8*/
            allCards.Add(new Creature("Adam Jensen", 4, 95, 3, 4, Type.FIGHTER, "Images\\CardImages\\adamCard", "Images\\FieldImages\\adamField"));
            /*9*/
            allCards.Add(new Creature("Salty Bouncer", 5, 85, 6, 4, Type.FIGHTER, "Images\\CardImages\\saltyCard", "Images\\FieldImages\\saltyField"));
            /*10*/
            allCards.Add(new Creature("Sanic", 5, 75, 6, 6, Type.FIGHTER, "Images\\CardImages\\sanicCard", "Images\\FieldImages\\sanicField"));
            /*11*/
            allCards.Add(new RareCreature("The Regginator", 7, 85, 7, 9, Type.FIGHTER, "Images\\CardImages\\regginatorCard", "Images\\FieldImages\\regginatorField"));

            //Genius Cards
            /*12*/
            allCards.Add(new Creature("Walter White", 3, 85, 3, 4, Type.GENIUS, "Images\\CardImages\\waltCard", "Images\\FieldImages\\waltField"));
            /*13*/
            allCards.Add(new Creature("Tony Stark", 5, 85, 5, 7, Type.GENIUS, "Images\\CardImages\\tonyCard", "Images\\FieldImages\\tonyStarkField"));
            /*14*/
            allCards.Add(new Creature("Todd Howard", 5, 70, 6, 6, Type.GENIUS, "Images\\CardImages\\toddCard", "Images\\FieldImages\\toddField"));
            /*15*/
            allCards.Add(new RareCreature("Gabe Newell", 6, 70, 7, 7, Type.GENIUS, "Images\\CardImages\\gabeCard", "Images\\FieldImages\\gabeField"));
            /*16*/
            allCards.Add(new Creature("Bill Nye The Science Guy", 7, 95, 4, 10, Type.GENIUS, "Images\\CardImages\\billCard", "Images\\FieldImages\\billField"));
            /*17*/
            allCards.Add(new RareCreature("Rick Sanchez", 7, 80, 7, 10, Type.GENIUS, "Images\\CardImages\\rickCard", "Images\\FieldImages\\rickField"));

            //Magic Cards
            /*18*/
            allCards.Add(new Creature("Glass Bones", 2, 90, 6, 1, Type.MAGIC, "Images\\CardImages\\glassBonesCard", "Images\\FieldImages\\glassBonesField"));
            /*19*/
            allCards.Add(new Creature("Rock Lobster", 3, 85, 5, 3, Type.MAGIC, "Images\\CardImages\\rockCard", "Images\\FieldImages\\rockField"));
            /*20*/
            allCards.Add(new RareCreature("Snoop Dogg", 4, 20, 4, 20, Type.MAGIC, "Images\\CardImages\\snoopDoggCard", "Images\\FieldImages\\snoopDoggField"));
            /*21*/
            allCards.Add(new Creature("Mr. Meeseeks", 5, 100, 5, 7, Type.MAGIC, "Images\\CardImages\\mrMeeSeeksCard", "Images\\FieldImages\\mrMeeseeksField"));
            /*22*/
            allCards.Add(new Creature("Cromulon", 7, 95, 6, 7, Type.MAGIC, "Images\\CardImages\\cromulonCard", "Images\\FieldImages\\CromulonField"));
            /*23*/
            allCards.Add(new RareCreature("Bob Ross", 7, 80, 9, 9, Type.MAGIC, "Images\\CardImages\\bobrossCard", "Images\\FieldImages\\bobRossField"));

            //Psycho Cards
            /*24*/
            allCards.Add(new Creature("Blue Eyes Orange Orange", 2, 40, 6, 2, Type.PSYCHO, "Images\\CardImages\\OrangeOrangeCard", "Images\\FieldImages\\OrangeOrange"));
            /*25*/
            allCards.Add(new Creature("Old Timer", 2, 85, 2, 4, Type.PSYCHO, "Images\\CardImages\\oldTimerCard", "Images\\FieldImages\\oldTimerField"));
            /*26*/
            allCards.Add(new RareCreature("Kim Jong Un", 4, 50, 7, 5, Type.PSYCHO, "Images\\CardImages\\kimJongUnCard", "Images\\FieldImages\\kimJongUnField"));
            /*27*/
            allCards.Add(new Creature("Brian Peppers", 4, 75, 6, 5, Type.PSYCHO, "Images\\CardImages\\brianPepsCard", "Images\\FieldImages\\brianPepsField"));
            /*28*/
            allCards.Add(new Creature("Trevor Phillips", 5, 70, 6, 7, Type.PSYCHO, "Images\\CardImages\\trevorCard", "Images\\FieldImages\\trevorField"));
            /*29*/
            allCards.Add(new RareCreature("Freaky Fred", 7, 85, 6, 8, Type.PSYCHO, "Images\\CardImages\\FreakyFredCard", "Images\\FieldImages\\freakyFredField"));

            //Spooky Cards
            /*30*/
            allCards.Add(new Creature("Count Chocula", 2, 85, 2, 1, Type.SPOOKY, "Images\\CardImages\\countChocCard", "Images\\FieldImages\\countchocfield"));
            /*31*/
            allCards.Add(new Creature("Spooky Police", 2, 75, 3, 2, Type.SPOOKY, "Images\\CardImages\\spookyPoliceCard", "Images\\FieldImages\\spookyPoliceField"));
            /*32*/
            allCards.Add(new RareCreature("Mr. Bones", 3, 95, 1, 10, Type.SPOOKY, "Images\\CardImages\\MrBonesCard", "Images\\FieldImages\\mrbonesField"));
            /*33*/
            allCards.Add(new Creature("King Ramsee", 3, 80, 4, 4, Type.SPOOKY, "Images\\CardImages\\KingRamsesCard", "Images\\FieldImages\\kingramsesField"));
            /*34*/
            allCards.Add(new Creature("Shrek", 6, 70, 8, 6, Type.SPOOKY, "Images\\CardImages\\ShrekCard", "Images\\FieldImages\\ShrekField"));
            /*35*/
            allCards.Add(new RareCreature("Mr. Skeltal", 7, 90, 6, 8, Type.SPOOKY, "Images\\CardImages\\mrSkeltalCard", "Images\\FieldImages\\mrSkeltalField"));

            //The Forbidden Cards
            /*36*/
            allCards.Add(new JackCard("Left Arm of Jack Myers", 3, 95, 2, 4, Type.FORBIDDEN, "Images\\CardImages\\leftArmOfJack", "Images\\FieldImages\\leftArmOfJackField", 1));
            /*37*/
            allCards.Add(new JackCard("Right Arm of Jack Myers", 3, 95, 2, 4, Type.FORBIDDEN, "Images\\CardImages\\rightArmOfJack", "Images\\FieldImages\\rightArmOfJackField", 2));
            /*38*/
            allCards.Add(new JackCard("Left Leg of Jack Myers", 3, 95, 2, 4, Type.FORBIDDEN, "Images\\CardImages\\leftLegOfJack", "Images\\FieldImages\\leftLegOFJackField", 3));
            /*39*/
            allCards.Add(new JackCard("Right Leg of Jack Myers", 3, 95, 2, 4, Type.FORBIDDEN, "Images\\CardImages\\rightLegOfJack", "Images\\FieldImages\\rightLegOfJackField", 4));
            /*40*/
            allCards.Add(new JackCard("Head of Jack Myers", 3, 95, 2, 4, Type.FORBIDDEN, "Images\\CardImages\\headOfJack", "Images\\FieldImages\\headofJackField", 5));

            //Enhancements
            /*41*/
            allCards.Add(new Enhancement("The Rock", 4, Enhancement.FATIGUE, -2, "Images\\EnhancementImages\\EtheRock"));
            /*42*/
            allCards.Add(new Enhancement("Airhorn", 2, Enhancement.ATTACK, 3, "Images\\EnhancementImages\\EAirhorn"));
            /*43*/
            allCards.Add(new Enhancement("Cheesy Keyboard", 2, Enhancement.ATTACK, -3, "Images\\EnhancementImages\\ECheese"));
            /*44*/
            allCards.Add(new Enhancement("Fallout 4", 5, Enhancement.CHANCE_TO_ATTACK, -50, "Images\\EnhancementImages\\Efallout4"));
            /*45*/
            allCards.Add(new Enhancement("The Fedora", 2, Enhancement.HEALTH, -2, "Images\\EnhancementImages\\Efedora"));
            /*46*/
            allCards.Add(new Enhancement("Monster Energy", 0, Enhancement.FATIGUE, -1, "Images\\EnhancementImages\\EMonster"));
            /*47*/
            allCards.Add(new Enhancement("Power Armor", 4, Enhancement.HEALTH, 5, "Images\\EnhancementImages\\Epowerarmor"));
            /*48*/
            allCards.Add(new Enhancement("Mom's Spaghetti", 3, Enhancement.CHANCE_TO_ATTACK, -25, "Images\\EnhancementImages\\Espaghetti"));
            /*49*/
            allCards.Add(new Enhancement("Stimpack", 2, Enhancement.HEALTH, 3, "Images\\EnhancementImages\\Estimpack"));
            /*50*/
            allCards.Add(new Enhancement("Oh Baby a Triple!", 3, Enhancement.ATTACK, 3, "Images\\EnhancementImages\\Etriple"));
            /*51*/
            allCards.Add(new Enhancement("Energy Sword", 0, Enhancement.ATTACK, 1, "Images\\EnhancementImages\\Esword"));
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>The instance.</returns>
        public static AllCards getInstance()
        {
            if (instance == null)
            {
                instance = new AllCards();
            }
            return instance;
        }

        /// <summary>
        /// Gets all cards.
        /// </summary>
        /// <returns>The all cards.</returns>
        public List<Card> GetAllCards()
        {
            return allCards;
        }

        /// <summary>
        /// Gets the name of the card from.
        /// </summary>
        /// <returns>The card from name.</returns>
        /// <param name="name">Name.</param>
        public Card GetCardFromName(String name)
        {
            foreach (Card card in allCards)
            {
                if (name.Equals(card.Name))
                {
                    return card;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the rare cards list.
        /// </summary>
        /// <returns>The rare cards list.</returns>
        public List<Card> GetRareCardsList()
        {
            List<Card> rareCards = new List<Card>();
            foreach (Card card in allCards)
            {
                if (card is Creature){
                if (((Creature)card) is RareCreature){
                    rareCards.Add(card);
                }
            }
        }
		return rareCards;
	}
}
}
