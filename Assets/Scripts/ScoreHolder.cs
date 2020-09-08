using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreHolder
{

    private static float score;

    public static float Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }
}