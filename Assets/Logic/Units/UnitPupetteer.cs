using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Simple Object used to test the Unit Object
public class UnitPupetteer : MonoBehaviour
{
    Unit _unit;

    // Start is called before the first frame update
    public void Start()
    {
        _unit = new Unit();
        _unit.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _unit.Tick();
    }
}
