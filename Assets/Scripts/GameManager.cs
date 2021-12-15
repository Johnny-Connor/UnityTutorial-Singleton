using UnityEngine;

public class GameManager : MonoBehaviour
{

    /* This variable is responsible for storing a instance of the GameManager class. 
     * In our algorithm, if it returns null, it'll mean that the class hasn't been instantiated yet. */
    private static GameManager _instance;

    /* Here lies the get property. Any script wanting to access our GameManager class will have to
     * mention this property to do so. */
    public static GameManager Instance
    {
        get
        {
            /* This condition happens only once during the execution of the game. That's because
             * "_instance" gets a value as soon as a GameObject with this script is created (take
             * a look at the "Awake" method). */
            if (_instance == null)
            {
                // Creating a GameObject called "GameManager".
                GameObject go = new GameObject("GameManager");
                // Adding this script inside it.
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
        // Again, this condition will happen only once throughout the execution of the game.
        if (_instance == null)
        {
            // Quick reminder: "this" refers to the current instance of the class.
            _instance = this;
            /* Prevents the GameObject "GameManager" from getting deleted during scene transitions.
             * It's important to do this because the GameObject we created is holding this script
             * as a component. Letting it be destroyed would result in the loss of the non static
             * variables values (such as "Money", for instance). */
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        // You can give initial values to your GameManager's variables in the "Start" method.
        Money = 3;
    }

}