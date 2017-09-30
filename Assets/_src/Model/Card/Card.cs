using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PoliticalSimulatorCore.Model
{
    [Serializable]
    public class Card
    {

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the fatigue value.
        /// </summary>
        /// <value>The fatigue value.</value>
        public int PlayFatigueValue
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <value>The image file path.</value>
        public string ImageFilePath
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the card back image path.
        /// </summary>
        /// <value>The card back image path.</value>
        public string CardBackImgPath
        {
            get;
            private set;
        }
 
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.Card"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="fatigueValue">Fatigue value.</param>
        /// <param name="imgFilePath">Image file path.</param>
        public Card(String name, int fatigueValue, String imgFilePath)
        {
            this.Name = name;
            this.PlayFatigueValue = fatigueValue;
            this.ImageFilePath = imgFilePath;

            //TODO Have a way for this to be a user choice
            this.CardBackImgPath = "Images\\CardImages\\CardBack";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.Card"/> class.
        /// Empty for serialization
        /// </summary>
        public Card() { }

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:PoliticalSimulatorCore.Model.Card"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:PoliticalSimulatorCore.Model.Card"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current
        /// <see cref="T:PoliticalSimulatorCore.Model.Card"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(Object obj)
        {
            if (obj.GetType().IsSubclassOf(typeof(Card)))
            {
                Card cardToCheck = (Card)obj;
                if (cardToCheck.Name.Equals(Name) && cardToCheck.PlayFatigueValue == PlayFatigueValue)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                return hash;
            }
        }
    }
}
