using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CoinUi : MonoBehaviour
{
    [SerializeField]
    private Text _coinText;
    [SerializeField]
    private UnityEvent _onCoinsUpdated;

    public void UpdateCoins(int coins)
    {
        _coinText.text = "X" + coins.ToString();
        _onCoinsUpdated?.Invoke(); 
    }

}
