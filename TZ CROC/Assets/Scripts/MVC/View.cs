using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class View : MonoBehaviour
{
    private Controller controller;
    private List<Stage> errors = new List<Stage>();
    private int countErrors = 0; public int CountErrors => countErrors;
    private void Start()
    {
        Init();
    }

    private void Init()
    {
        controller = GetComponent<Controller>();
    }

    public void SwitchStateObject(Stage stage)
    {
        controller.CheckOnThrow(stage);
    }

    public void EditErrors( Stage stage )
    {
        if( errors.Find(num => num == stage) == null)
        {
            errors.Add(stage);
            countErrors++;
        }
        else
        {
            errors.Remove(stage);
        }
    }

    public void AddError(Stage stage)
    {
        countErrors++;
        Debug.Log("Error! " + stage.name);
    }

    private void Update()
    {
        //getObject();
    }
    //private void getObject()
    //{
    //    RaycastHit hit;
    //    Ray MyRay;
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        MyRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        //Debug.DrawRay(MyRay.origin, MyRay.direction * 100, Color.yellow);
    //        if (Physics.Raycast(MyRay, out hit, 100))
    //        {
    //            MeshFilter filter = hit.collider.GetComponent(typeof(MeshFilter)) as MeshFilter;
    //            if (filter)
    //            {
    //                Debug.Log(filter.gameObject.name);
    //            }
    //        }
    //    }
    //}
}
