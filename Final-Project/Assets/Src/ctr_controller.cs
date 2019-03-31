using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ctr_controller : MonoBehaviour
{
    public GameObject prefab;
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


    }

    public void person_panel_init(mod_person person)
    {
        Debug.Log(person.first_name);
        GameObject person_panel = (GameObject)Instantiate(prefab, GameObject.FindGameObjectWithTag("Canvas").transform);
        //person_panel.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
    }
}
