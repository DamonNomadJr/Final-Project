using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ctr_controller : MonoBehaviour
{
    public GameObject referencePoint;
    public GameObject prefab;
    protected List<int> people = new List<int>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100) && hit.transform.gameObject.GetComponent<mod_person>() != null && Input.GetMouseButtonDown(0))
            person_panel_init(hit.transform.gameObject.GetComponent<mod_person>());
         find_cordinate();

    }

    private Vector3 find_cordinate()
    {
        return this.referencePoint.transform.position;
    }


    public void person_panel_init(mod_person person)
    {
        Debug.Log(person.id);
        if (!idExists(person.id))
        {
            Debug.Log(person.first_name);
            Debug.Log(person.last_name);
            Debug.Log(person.id);
            Debug.Log(person.facebook_id);
            GameObject person_panel = (GameObject)Instantiate(prefab, referencePoint.transform.position, 
                gameObject.transform.rotation * Quaternion.identity);
            person_panel.transform.eulerAngles = new Vector3(0f, person_panel.transform.eulerAngles.y, 0f);
            person_panel.transform.position = new Vector3(person_panel.transform.position.x, 1, person_panel.transform.position.z);
            person_panel.GetComponent<ctr_panel>().set_name(person.first_name);
            person_panel.GetComponent<ctr_panel>().set_lastname(person.last_name);
            person_panel.GetComponent<ctr_panel>().id = person.id;
            this.people.Add(person.id);
        }
        Debug.Log("Person exits");
    }

    public void deleted(int id)
    {
        if (idExists(id))
        {
            people.Remove(id);
        }
    }

    private bool idExists(int id)
    {
        for (var i = 0; i < people.Count; i++)
            if (people[i] == id) return true;
        return false;
    }

}
