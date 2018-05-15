using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace YjaruTCG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {

        private ObservableCollection<Card> p1deck;
        private ObservableCollection<Card> p2deck;
        private ObservableCollection<Card> p1field = new ObservableCollection<Card>();
        private ObservableCollection<Card> p2field = new ObservableCollection<Card>();

        public Game()
        {
            this.InitializeComponent();
            p1deck = DeckManager.getDeck(1);
            p2deck = DeckManager.getDeck(2);
        }

        private void moveToField(Card c, int player)
        {
            if (player == 1)
            {
                p1field.Add(c);
            }
            if(player == 2)
            {
                p2field.Add(c);
            }

        }

        private void addToConsole(String message)
        {

            Console.Text += "\n- " + message;

        }

        private void P1GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Card c = (Card)e.ClickedItem;
            p1deck.Remove(c);
            moveToField(c, 1);
            addToConsole("Player one puts " + c.name + " into play.");
        }

        private void P2GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Card c = (Card)e.ClickedItem;
            p2deck.Remove(c);
            moveToField(c, 2);
            addToConsole("Player two puts " + c.name + " into play.");
        }
    }
}
