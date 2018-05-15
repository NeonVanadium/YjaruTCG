using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YjaruTCG
{
    class DeckManager
    {

        public static ObservableCollection<Card> getDeck()
        {

            ObservableCollection<Card> deck = new ObservableCollection<Card>();

            deck.Add(new Card { name = "William Mayden", cost = 3, type = "Character", attack=4, health=5, legendary=true, color="Green", text = "The Harrondian Archaeologist can never quite seem to escape involvement in world-changing conflict." } );
            deck.Add(new Card { name = "Gael, the Unkillable", cost = 5, type = "Character", attack = 4, health = 5, legendary = true, color = "Blue", text = "A combination of terrible luck, skill, and unwavering resilience led to this particular university mage becoming one of the most renowned fighters in the world." });
            deck.Add(new Card { name = "Greater Shard", cost = 4, type = "Item", health = 2, legendary = true, color = "Red", text = "One of the three greater shards of the creator." });


            return deck;

        }

    }
}
