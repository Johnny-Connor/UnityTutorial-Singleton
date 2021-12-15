using System.Globalization;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text MoneyText, CoffeesOwnedText, PhonesOwnedText, PCsOwnedText, CarsOwnedText;

    void Update()
    {
        /* You might be wondering: how can "GameManager.cs" work without it being in the Hierarchy? The reason for that's because
         * every other script in the assets folder actually functions outside the Hierarchy too. We normally don't notice that 
         * because it's impossible to use non static methods/functions that aren't in the Hierarchy. You can comprove it by yourself
         * by making either "Instance" or "_instance" non static and trying to run the game. */
        MoneyText.text = "Money: $" + GameManager.Instance.Money.ToString("n0", CultureInfo.InvariantCulture);
        CoffeesOwnedText.text = "Coffees Owned: " + GameManager.Instance.CoffeesOwned.ToString("n0", CultureInfo.InvariantCulture);
        PhonesOwnedText.text = "Phones Owned: " + GameManager.Instance.PhonesOwned.ToString("n0", CultureInfo.InvariantCulture);
        PCsOwnedText.text = "PC's Owned: " + GameManager.Instance.PCsOwned.ToString("n0", CultureInfo.InvariantCulture);
        CarsOwnedText.text = "Cars Owned: " + GameManager.Instance.CarsOwned.ToString("n0", CultureInfo.InvariantCulture);
    }

}
