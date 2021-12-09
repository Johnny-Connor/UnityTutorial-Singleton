using System.Globalization;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text MoneyText, CoffeesOwnedText, PhonesOwnedText, PCsOwnedText, CarsOwnedText;

    void Update()
    {
        MoneyText.text = "Money: $" + GameManager.Instance.Money.ToString("n0", CultureInfo.InvariantCulture);
        CoffeesOwnedText.text = "Coffees Owned: " + GameManager.Instance.CoffeesOwned.ToString("n0", CultureInfo.InvariantCulture);
        PhonesOwnedText.text = "Phones Owned: " + GameManager.Instance.PhonesOwned.ToString("n0", CultureInfo.InvariantCulture);
        PCsOwnedText.text = "PC's Owned: " + GameManager.Instance.PCsOwned.ToString("n0", CultureInfo.InvariantCulture);
        CarsOwnedText.text = "Cars Owned: " + GameManager.Instance.CarsOwned.ToString("n0", CultureInfo.InvariantCulture);
    }

}
