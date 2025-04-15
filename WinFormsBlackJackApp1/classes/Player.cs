using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static WinFormsBlackJackApp1.classes.Deck;

namespace WinFormsBlackJackApp1.classes
{
    private List<Hand> hands;

    public Player()
    {
      Hands = new List<Hand>();
        for (int i = 0; i < 2; i++)
        {
            hands.Add(new Hand());
        }
    
    }

    public void stand(Hand hand)
    {
        hand.ToStand();
    }

    public list<hand> GetHands()
    {
        return hands;
    }
}
