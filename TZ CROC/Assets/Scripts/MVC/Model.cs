using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    private List<Stage> stages { get; set; }
    private List<Stage> notBackToStartStages { get; set; }
    public List<Stage> NotBackToStartStages => notBackToStartStages;

    private bool isBack = false;

    private int currentNum;
    public Model(List<Stage> stages)
    {
        this.stages = stages;
        notBackToStartStages = new List<Stage>();
        fillNotBackToStartStages();
    }

    public bool CheckStages(Stage stage)
    {
        if( !isBack )
            currentNum = stages.FindIndex(num => num == stage);
        else
            currentNum = notBackToStartStages.FindIndex(num => num == stage);
        if (isFullTrue() & !isBack)
        {
            isBack = true;
            return true;
        }
        if (!isBack)
            return isRightStageFromStartToEnd(currentNum);
        else
            return isRightStageFromEndToStart(currentNum);
    }

    private bool isRightStageFromEndToStart(int currentNum)
    {
        for (int i = 0; i <= currentNum; i++)
        {
            if (notBackToStartStages[i].isCompleted)
                return false;
        }
        for (int i = currentNum + 1; i < notBackToStartStages.Count; i++)
        {
            if (!notBackToStartStages[i].isCompleted)
                return false;
        }
        return true;
    }

    private bool isRightStageFromStartToEnd(int currentNum)
    {
        for (int i = 0; i <= currentNum; i++)
        {
            if (!stages[i].isCompleted)
                return false;
        }
        for (int i = currentNum + 1; i < stages.Count; i++)
        {
            if (stages[i].isCompleted)
                return false;
        }
        return true;
    }

    private bool isFullTrue()
    {
        for (int i = 0; i < stages.Count; i++)
        {
            if (!stages[i].isCompleted)
                break;
            if (i == stages.Count - 1)
                return true;
        }
        return false;
    }

    private void fillNotBackToStartStages()
    {
        for (int i = 0; i < stages.Count; i++)
        {
            if (stages[i].isBackToStartState)
                notBackToStartStages.Add(stages[i]);
        }
        notBackToStartStages.Reverse();
    }
}
