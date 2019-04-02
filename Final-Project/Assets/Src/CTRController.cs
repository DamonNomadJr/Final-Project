using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CTRController : MonoBehaviour
{
    public GameObject referencePoint;
    public GameObject prefab;
    protected List<string> people = new List<string>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100) && hit.transform.gameObject.GetComponent<MODPerson>() != null && Input.GetMouseButtonDown(0))
            person_panel_init(hit.transform.gameObject.GetComponent<MODPerson>());
         find_cordinate();

    }

    private Vector3 find_cordinate()
    {
        return this.referencePoint.transform.position;
    }


    public void person_panel_init(MODPerson person)
    {
        Debug.Log(person.TwitterId);
        if (!idExists(person.TwitterId))
        {
            //Search that person in twitter API
            gameObject.GetComponent<CTRTwitterPortal>().pushToSearch(person.TwitterId);

            //Instantiating  the panel
            GameObject person_panel = (GameObject)Instantiate(prefab, referencePoint.transform.position, 
                gameObject.transform.rotation * Quaternion.identity);
            
            //Fixing Panel Positioning
            person_panel.transform.eulerAngles = new Vector3(0f, person_panel.transform.eulerAngles.y, 0f);
            person_panel.transform.position = new Vector3(person_panel.transform.position.x, 2f, person_panel.transform.position.z);

            //Setting Panel's twitter id to fetch the correct info
            person_panel.GetComponent<CTRPanel>().id = person.TwitterId;
            // person_panel.GetComponent<CTRPanel>().Run();

            this.people.Add(person.TwitterId);
            

        }
        Debug.Log("Person exits");
    }

    //CTRPanel will call this for closing
    public void deleted(string id)
    {
        if (idExists(id))
        {
            people.Remove(id);
        }
    }

    private bool idExists(string id)
    {
        for (var i = 0; i < people.Count; i++)
            if (people[i] == id) return true;
        return false;
    }

}
