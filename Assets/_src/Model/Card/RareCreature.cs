﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PoliticalSimulatorCore.Model
{
    [Serializable]
    public class RareCreature: Creature
    {
        private const long serialVersionUID = 1L;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.RareCreature"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="fatigueValue">Fatigue value.</param>
        /// <param name="chanceToHit">Chance to hit.</param>
        /// <param name="attack">Attack.</param>
        /// <param name="health">Health.</param>
        /// <param name="type">Type.</param>
        /// <param name="imgFilePath">Image file path.</param>
        /// <param name="fieldImgPath">Field image path.</param>
        public RareCreature(String name, int fatigueValue, int chanceToHit, int attack, int health, Type type, String imgFilePath, String fieldImgPath): base(name, fatigueValue, chanceToHit, attack, health, type, imgFilePath, fieldImgPath)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.RareCreature"/> class.
        /// </summary>
        public RareCreature()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:PoliticalSimulatorCore.Model.RareCreature"/> class.
        /// </summary>
        /// <param name="rc">Rc.</param>
        public RareCreature(RareCreature rc): base(rc.Name, rc.PlayFatigueValue, rc.ChanceToHit, rc.AttackValue, rc.HealthValue,
                    rc.CreatureType, rc.ImageFilePath, rc.FieldImgPath)
        {
        }
    }
}
