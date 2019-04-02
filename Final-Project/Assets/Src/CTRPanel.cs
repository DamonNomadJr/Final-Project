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

    public IEnumerator Update()
    {
        if (Controller.GetComponent<CTRTwitterPortal>().profileExists(this.id)){
            person = Controller.GetComponent<CTRTwitterPortal>().getProfile(this.id);
            Debug.LogWarning("Setting Person");
            this.set_name(this.person.screen_name);
            this.set_screenid(this.person.id.ToString());
            this.set_description(this.person.description);
            this.set_followers(this.person.followers_count.ToString());
            //    this.set_avatar(this.person.profile_image_url);
        }
        else
        {
            Debug.LogWarning("Person Didnt Exist");
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

    public async void set_avatar(string url)
    {
        WWW www = new WWW(url);
        ProfileIcon.GetComponent<Image>().sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
    }

}
