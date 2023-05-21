using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    //�������ڸ��� ȣ��Ǵ� �Լ��� �̱����� ���� ������ ���۵Ǵ� ������ �������� attribute
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    // ���� �������� �ʿ��� �������� Init �Լ��� �־������ν� ����
    private static void Init()
    {
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = " GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}