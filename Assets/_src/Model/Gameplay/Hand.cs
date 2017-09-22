using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PoliticalSimulatorCore.Model {
    class Hand : List<Card> {
        public Hand(int capacity) : base(capacity) {
        }
    }
}
