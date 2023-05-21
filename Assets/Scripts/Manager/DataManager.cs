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
            // bestScore�� value�� �ٸ���� �̺�Ʈ�� �߻���Ŵ
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
            // ���� ������� ���罺�ھ ������ְ�
            OnCurScoreChanged?.Invoke(value);
            curScore = value;

            // ���� ���罺�ھ BestScore ���� ���� ū ��쿡��
            if(curScore > BestScore)
                BestScore = curScore;   // ���� ���ھ bestscore�� �ȴ�.
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
