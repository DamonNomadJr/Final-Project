using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Web.Helpers;
using Web.Twitter.API;
using Web.Twitter.DataStructures;

public class CTRTwitterPortal : MonoBehaviour
{
    [Header("Twitter API Keys")]
    private string TwitterAPIConsumerKey = "kaf1MqAm5wRoQ46h0aNsRl8Cf";
    private string TwitterAPIConsumerSecret = "EFIrvL0mHUlEyyd5DuBJsiuozFnnvjquJqJmVSuOxvfD0Z1vRk";
    [Header("Twitter Gnerated Token")]
    public static WebAccessToken TwitterAPIAccessToken;
    [Header("Twitter Profile")]
    public List<UserProfile> Profile = new List<UserProfile>();
    public Tweet[] tweets;

    private List<string> id_lists = new List<string>();

    // Start is called before the first frame update
    private void Start()
    {
        TwitterAPIAccessToken = WebHelper.GetTwitterApiAccessToken(TwitterAPIConsumerKey, TwitterAPIConsumerSecret);
        
    }

    public void Update()
    {
        //To change the panel info with provided user IDs;
        if(id_lists.Count > 0)
        {
            this.eggProfile(this.id_lists[0]);
            
            this.id_lists.RemoveRange(0, 1);
        }
        // foreach (UserProfile person in this.Profile)
        // {
        //     this.FindTweets(person.id.ToString());
        // }

    }

    private async void eggProfile(string id)
    {
        if(!profileExists(id))
            Profile.Add(await TwitterRestApiHelper.GetUserProfileByUserId(id, TwitterAPIAccessToken.access_token));
    }

    public void pushToSearch(string id)
    {
        this.id_lists.Add(id);
    }

    public bool profileExists(string id)
    {
        foreach (UserProfile person in this.Profile)
            if (person.id.ToString() == id) return true;
        return false;
    }

    public UserProfile getProfile(string id)
    {
        foreach (UserProfile person in this.Profile)
            if (person.id.ToString() == id) return person;
        return null;
    }

    public async void FindTweets(string id)
    {
        tweets = await TwitterRestApiHelper.GetLatestTweetsFromUserByUserId(id, CTRTwitterPortal.TwitterAPIAccessToken.access_token, 1);
    }

}