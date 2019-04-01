using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctr_panel : MonoBehaviour
{

    public GameObject nameField, lastnameField;
    public int id { set; get;  }

    public void close()
    {
        Destroy(gameObject);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ctr_controller>().deleted(id);
    }

    public void set_name(string given_name)
    {
        this.nameField.GetComponent<Text>().text = given_name;
    }
    public void set_lastname(string given_last_name)
    {
        this.lastnameField.GetComponent<Text>().text = given_last_name;
    }
    public void set_avatar()
    {

    }

}
