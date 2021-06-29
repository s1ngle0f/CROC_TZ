using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Error : MonoBehaviour
{
    private Text text;
    [SerializeField] private View view;
    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = "Errors: " + view.CountErrors;
    }
}
