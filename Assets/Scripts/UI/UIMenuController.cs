﻿using UnityEngine;
using System.Collections;

public class UIMenuController : MonoBehaviour
{

    // This is the parent of the menus
    Transform parent;

    // Use this for initialization
    void Awake()
    {
        // Set the parent for all menu to uses.
        parent = this.gameObject.transform;

        //Add the menus.
        AddMenu("MenuTop");
        AddMenu("MenuSubHolder");
        AddMenu("MenuBottom");
        AddMenu("MenuConstruction");
    }

    void Start()
    {
        // Add the Right Menu because of the mouse controller needed do it here.
        AddMenu("MenuRight");
    }

    // Use this function to add all the menus.
    void AddMenu(string menuName)
    {
        GameObject tempGoObj;

        tempGoObj = (GameObject)Instantiate(Resources.Load("UI/" + menuName));
        tempGoObj.name = menuName;

        tempGoObj.transform.SetParent(parent, false);

    }
}
