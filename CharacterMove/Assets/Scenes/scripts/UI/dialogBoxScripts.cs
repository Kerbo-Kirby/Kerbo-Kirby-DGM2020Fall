﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class dialogBoxScripts : MonoBehaviour
{

    [SerializeField] private GameObject box;


    public Image boo;

    public Text dfk;
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        box.SetActive(true);
    }
    
    
}
