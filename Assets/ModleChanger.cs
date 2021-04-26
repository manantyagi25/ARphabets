using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModleChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] models;
    public GameObject randi;

    public void change_model(int n)
    {
        randi.GetComponent<MeshFilter>().mesh = models[n].GetComponent<MeshFilter>().mesh;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
