using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageController : MonoBehaviour
{
    // ������������ ���� ����Ʈ�� ������ ����
    public int StagePoint = 0;
    // ����Ʈ ǥ�ÿ� �ؽ�Ʈ
    public Text pointText;
    // �������� ��Ʈ�ѷ��� �ν��Ͻ��� �����ϴ� static �����Դϴ�.
    public static StageController instance;
    // �ٸ� �ڵ� ������ StageController.instance.AddPoint(10)�� ���� ���·� ����� �� �ְ� �˴ϴ�.

    // 2024-3-15 Awake -> Start
    private void Start()
    {
        instance = this;
        // �ȳ�â �� ����
        var alert = new DialogDataAlert("���� ����", "��ȯ�Ǵ� �����ӵ��� ���ں��ϰ� �����ϼ���.", delegate () { Debug.Log("OK�� �������ϴ�"); });

        // �Ŵ����� ���
        DialogManager.Instance.Push(alert);
    }

    public void AddPoint(int point)
    {
        StagePoint += point;
        pointText.text = StagePoint.ToString();
    }

    public void FinishGame() 
    {
        //Application.LoadLevel(Application.loadedLevel); �� ���� �ڵ� (����� ���� �ʽ��ϴ�.)
        SceneManager.LoadScene("Stage");
    }
}
