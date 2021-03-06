﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;

    private void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    
    }
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int costStars)
    {
        //if (stars>=costStars)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}
        return stars >= costStars;
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
       
        stars -= amount;
        UpdateDisplay();
        
    }
}
