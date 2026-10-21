using NUnit.Framework;
using System;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //variables
    public TextMeshProUGUI foodText;
    public string currentFood;
    //make an array that will hold strings
    public string[] Shoppingarray = new string[10]
    {
        /*0*/ "Saffron",
        /*1*/ "Milk",
        /*2*/ "Bread",
        /*3*/ "Eggs",
        /*4*/ "Cheese",
        /*5*/ "Peanut Butter",
        /*6*/ "Oil",
        /*7*/ "Noodles",
        /*8*/ "Ham",
        /*9*/ "Bacon"
    };
    //the number of food in the array
    public int currentFoodIndex = 0;

    //singleton
    public static GameManager instance;
    //wake is called when the scripts initiates
    private void Awake()
    {
        //if there is not an instance of this script in game, make this the instance
        if (instance == null)
        {
            instance = this;
            //Do not destroy this game object when loading a new scene
            DontDestroyOnLoad(gameObject);
        }
        else //if there are duplicates this means destroy all duplicates except the main instance
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentFood = Shoppingarray[currentFoodIndex];
    }

    // Update is called once per frame
    void Update()
    {
        foodText.text = currentFood;
    }
}
