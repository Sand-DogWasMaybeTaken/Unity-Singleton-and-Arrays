using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickScript : MonoBehaviour
{
    //variables
    private Camera mainCam;
    //Awake is called before the first frame
    private void Awake()
    {
        mainCam = Camera.main;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if the left mouse button is pressed
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Raycasthit();
        }
    }

    private void Raycasthit()
    {
        //current mouse position
        Vector2 mousePos = Mouse.current.position.ReadValue();
        //convert a screen position to a ray
        Ray ray = mainCam.ScreenPointToRay(mousePos);
        //cast a ray if it hits something, do something
        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
       
        //if we hit something
        if (hit2D.collider != null)
        {
            //set the current food to the next number in the array
            if (GameManager.instance.currentFoodIndex < GameManager.instance.Shoppingarray.Length - 1)
            {
                GameManager.instance.currentFoodIndex ++;
                GameManager.instance.currentFood = GameManager.instance.Shoppingarray[GameManager.instance.currentFoodIndex];
            }
            else
            {
                GameManager.instance.currentFoodIndex = 0;
                GameManager.instance.currentFood = GameManager.instance.Shoppingarray[0];
            }
        }
    }
}
