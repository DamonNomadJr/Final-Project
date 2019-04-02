using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Web.Helpers;
using Web.Twitter.API;
using Web.Twitter.DataStructures;

public class MODPerson : MonoBehaviour
{
    public string TwitterId;

    private GameObject _controller;
    private bool found = false;
    public GameObject Camera;
    public Tweet[] latest_tweet;

    public void Start()
    {
        this._controller = GameObject.FindWithTag("MainCamera");
        this.LatestTweets();
        
    }

    public void Update()
    {

    }

    public async void LatestTweets()
    {
        
    }




    
}
