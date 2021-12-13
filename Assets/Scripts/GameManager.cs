﻿using UnityEngine;

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