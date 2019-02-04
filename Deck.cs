using System;
using System.Collections;
using System.Collections.Generic;

namespace scallywags
{
    public class Deck
    {
        public int size;
        public int currentSize;
        public List<string> names;
        public List<string> descriptions;
        public List<string> systems;
        private static Random rnd = new Random();

        public Deck(int maxSize = 10)
        {
            size = maxSize;
            currentSize = maxSize;
            names = new List<string> { "Eyepatch", "Peg Leg", "Rifled Cannons", "Jolly Roger" };
            descriptions = new List<string> { "Speed +", "Targeting +", "Ship Power +", "Ship Power +" };
            systems = new List<string> { "Crew", "Crew", "Armament", "Rigging", };
        }

        public Card DrawCard(int cardsToDraw = 1)
        {
            if (currentSize > 0)
            {
                // Set a random number and use it for both lists
                int r = rnd.Next(names.Count);
                int cardPower = (rnd.Next(4) + 1);
                currentSize--;
                return new Card(names[r], descriptions[r],cardPower, systems[r]);
            }
            else
            {
                return null;
            }
        }
    }
}