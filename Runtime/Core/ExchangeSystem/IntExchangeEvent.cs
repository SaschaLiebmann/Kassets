using UnityEngine;

namespace Kassets.ExchangeSystem
{
    [CreateAssetMenu(fileName = "IntExchangeEvent", menuName = MenuHelper.DefaultExchangeEventMenu + "IntExchangeEvent")]
    public class IntExchangeEvent : ExchangeEvent<int>
    {
    }
}