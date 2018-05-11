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

            deck.Add(new Card { name = "William Mayden", cost = 3, type = "Troop", legendary=true, color="Green", text = "The Harrondian Archaeologist can never quite seem to escape involvement in world-changing conflict." } );

            return deck;

        }

    }
}
