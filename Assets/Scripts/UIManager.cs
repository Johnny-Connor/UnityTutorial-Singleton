using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text MoneyText, CoffeesOwnedText, PhonesOwnedText, PCsOwnedText, CarsOwnedText;

    void Update()
    {
        MoneyText.text = "Money: $" + GameManager.Instance.Money;
        CoffeesOwnedText.text = "Coffees Owned: " + GameManager.Instance.CoffeesOwned;
        PhonesOwnedText.text = "Phones Owned: " + GameManager.Instance.PhonesOwned;
        PCsOwnedText.text = "PC's Owned: " + GameManager.Instance.PCsOwned;
        CarsOwnedText.text = "Cars Owned: " + GameManager.Instance.CarsOwned;
    }

}
