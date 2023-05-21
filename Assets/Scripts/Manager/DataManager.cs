using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    private int bestScore;
    public int BestScore
    {
        get { return bestScore; }
        set
        {
            // bestScore와 value가 다른경우 이벤트를 발생시킴
            if (bestScore != value)            
                OnBestScoreChanged?.Invoke(value);
                bestScore = value;           
        }
    }         
    public event UnityAction<int> OnBestScoreChanged;

    private int curScore;

    public int CurScore
    {
        get { return curScore; }
        set
        {
            // 같은 방식으로 현재스코어를 만들어주고
            OnCurScoreChanged?.Invoke(value);
            curScore = value;

            // 만약 현재스코어가 BestScore 보다 값이 큰 경우에는
            if(curScore > BestScore)
                BestScore = curScore;   // 현재 스코어가 bestscore가 된다.
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
