using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private List<Stage> stages;
    private Model model;
    private View view;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        model = new Model(stages);
        view = GetComponent<View>();
    }

    public void CheckOnThrow(Stage stage)
    {
        if (model.CheckStages(stage))
            Debug.Log("Right!");
        else
        {
            Debug.Log("Error! Plz check " + stage.name);
            view.EditErrors(stage);
        }
    }
}
