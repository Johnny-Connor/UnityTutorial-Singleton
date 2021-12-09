using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public void BuyCoffee()
    {
        if (GameManager.Instance.Money >= 3)
        {
            GameManager.Instance.Money -= 3;
            GameManager.Instance.CoffeesOwned++;
        }
        else
        {
            Debug.Log("Not enough cash, stranger...");
        }
    }

    public void BuyPhone()
    {
        if (GameManager.Instance.Money >= 300)
        {
            GameManager.Instance.Money -= 300;
            GameManager.Instance.PhonesOwned++;
        }
        else
        {
            Debug.Log("Not enough cash, stranger...");
        }
    }

    public void BuyPC()
    {
        if (GameManager.Instance.Money >= 3000)
        {
            GameManager.Instance.Money -= 3000;
            GameManager.Instance.PCsOwned++;
        }
        else
        {
            Debug.Log("Not enough cash, stranger...");
        }
    }

    public void BuyCar()
    {
        if (GameManager.Instance.Money >= 45000)
        {
            GameManager.Instance.Money -= 45000;
            GameManager.Instance.CarsOwned++;
        }
        else
        {
            Debug.Log("Not enough cash, stranger...");
        }
    }

    public void Work()
    {
        GameManager.Instance.Money += GameManager.Instance.CoffeesOwned + GameManager.Instance.PhonesOwned * 9 + GameManager.Instance.PCsOwned * 81 + GameManager.Instance.CarsOwned * 729;
    }

    public void GoToScene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

}
