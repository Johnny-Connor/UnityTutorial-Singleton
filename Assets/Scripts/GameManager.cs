using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This variable is responsible for storing a instance of the GameManager class. In our algorithm, if it returns null, it'll mean that the class hasn't been instantiated yet.
    private static GameManager _instance;

    // Here lies the get property. Any script wanting to access our GameManager class will have to mention this property to do so.
    public static GameManager Instance
    {
        get
        {
            // To be commented...
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

    void Awake()
    {
        if (_instance == null)
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
        //You can give initial values to your GameManager's variables in the "Start" function.
        Money = 3;
    }

}