using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    // variables
    public GameObject MenuStartPosition, MenuActivePosition, MenuPanel;

    public bool MenuNonVisable, MenuVisable;

    public float MovementSpeed, tempPosition;


    void Start()
    {
        MenuPanel.transform.position = MenuStartPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if this menu should be actiove move panel to active position
        if(MenuVisable)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuActivePosition.transform.position, MovementSpeed * Time.deltaTime);
            if (MenuPanel.transform.localPosition.x == tempPosition)
            {
                MenuVisable = false;
                MenuPanel.transform.position = MenuActivePosition.transform.position;
                tempPosition = -9999999999.99f;
            }
            if (MenuVisable)
            {
                tempPosition = MenuPanel.transform.position.x;
            }
        }
        // if the menu should be non visable move the panel back to starting position. 
        if(MenuNonVisable)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuStartPosition.transform.position, MovementSpeed * Time.deltaTime);
            if (MenuPanel.transform.localPosition.x == tempPosition)
            {
                MenuNonVisable = false;
                MenuPanel.transform.position = MenuStartPosition.transform.position;
                tempPosition = -9999999999.99f;
            }
            if (MenuNonVisable)
            {
                tempPosition = MenuPanel.transform.position.x;
            }
        }
    }
    // Move to active 
    public void MakeMenuVisable()
    {
        MenuNonVisable = false;
        MenuVisable = true;

    }

    // Move to non-active
    public void MakeMenuNonVisable()
    {
        MenuVisable = false;
        MenuNonVisable = true;

    }
}
