using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Web.Helpers;
using Web.Twitter.API;
using Web.Twitter.DataStructures;

public class CTRPanel : MonoBehaviour
{
    public GameObject Controller;
    public GameObject ProfileIcon, ScreenName, UserID, UserDescription, FollowersCount, Background;
    public string id;
    public UserProfile person;

    void Awake()
    {
        this.Controller = GameObject.FindWithTag("MainCamera");
        Debug.LogWarning("AWAKEN");
    }

    void Update()
    {
        if (this.id.Length > 0 && this.person != null)
        {
            if (this.person.id.ToString() != this.id)
            {
                Debug.LogWarning("Finding Person");
                this.person = Controller.GetComponent<CTRTwitterPortal>().getProfile(this.id);
            } else
            {
                Debug.LogWarning("Setting Person");
                this.set_name(this.person.screen_name);
                this.set_screenid(this.person.id.ToString());
                this.set_description(this.person.description);
                this.set_followers(this.person.followers_count.ToString());
            }
            
        }
    }

    public void close()
    {
        Destroy(gameObject);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CTRController>().deleted(id);
    }

    public void set_name(string name)
    {
        this.ScreenName.GetComponent<Text>().text = name;
    }

    public void set_screenid(string id)
    {
        this.UserID.GetComponent<Text>().text = id;
    }

    public void set_description(string desc)
    {
        this.UserDescription.GetComponent<Text>().text = desc;
    }

    public void set_followers(string count)
    {
        this.FollowersCount.GetComponent<Text>().text = count;
    }

    public void set_avatar()
    {

    }

}
