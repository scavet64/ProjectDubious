using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PoliticalSimulatorCore.Model {
    class Field : List<Creature> {
        public Field(int capacity) : base(capacity) {
        }
    }
}
