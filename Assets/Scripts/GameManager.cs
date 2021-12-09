using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            //create logic to create the instance
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public int Money { get; set; }
    public int CoffeesOwned { get; set; }
    public int PhonesOwned { get; set; }
    public int PCsOwned { get; set; }
    public int CarsOwned { get; set; }
    private bool gotStarterMoney;

    void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (gotStarterMoney == false)
        {
            Money = 9;
            gotStarterMoney = true;
        }
    }

}