using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    //시작하자마자 호출되는 함수로 싱글톤이 없이 게임이 시작되는 현상을 막기위한 attribute
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    // 게임 시작전에 필요한 설정들을 Init 함수에 넣어줌으로써 관리
    private static void Init()
    {
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = " GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}
