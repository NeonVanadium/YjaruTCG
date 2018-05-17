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

        public static ObservableCollection<Card> getDeck(int player)
        {

            ObservableCollection<Card> deck = new ObservableCollection<Card>();

            if (player == 1)
            {
                deck.Add(new Card { name = "William Mayden", cost = 3, type = "Character", attack = 4, health = 5, legendary = true, color = "Green", text = "The Harrondian Archaeologist can never quite seem to escape involvement in world-changing conflict." });
                deck.Add(new Card { name = "Gael m'Ziilki, the Unkillable", cost = 5, type = "Character", attack = 3, health = 7, legendary = true, color = "Blue", text = "A combination of terrible luck, skill, and unwavering resilience led to this university mage's becoming one of the world's most renowned fighters." });
                deck.Add(new Card { name = "Greater Shard", cost = 4, type = "Item", health = 2, legendary = true, color = "Red", text = "A piece of the soul of the creator - one of twelve, and one of the three larger shards." });
                deck.Add(new Card { name = "Portal: Cowissk", cost = 2, type = "Item", health = 2, legendary = false, color = "Purple", text = "A portal leading to the College of William, the Second Sorcerer-King, the largest arcane college in the East." });
            }
            if(player == 2)
            {

                Card ayanFootsoldier = new Card { name = "Ayan Footsoldier", image="Assets/AyanFootsoldier.png", cost = 1, type = "Character", attack = 2, health = 2, legendary = false, color = "LightBlue", text = "Though the country's glory days are long in the past, the Ayans' stalwart devotion to their country remains firm." };

                for(int i = 0; i < 7; i++)
                {

                    deck.Add(ayanFootsoldier);

                }

            }
            return deck;

        }

    }
}
