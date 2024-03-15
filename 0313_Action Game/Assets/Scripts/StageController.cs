using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageController : MonoBehaviour
{
    // 스테이지에서 쌓은 포인트를 저장할 변수
    public int StagePoint = 0;
    // 포인트 표시용 텍스트
    public Text pointText;
    // 스테이지 컨트롤러의 인스턴스를 저장하는 static 변수입니다.
    public static StageController instance;
    // 다른 코드 내에서 StageController.instance.AddPoint(10)과 같은 형태로 사용할 수 있게 됩니다.

    // 2024-3-15 Awake -> Start
    private void Start()
    {
        instance = this;
        // 안내창 값 설정
        var alert = new DialogDataAlert("게임 시작", "소환되는 슬라임들을 무자비하게 도륙하세요.", delegate () { Debug.Log("OK를 눌렀습니다"); });

        // 매니저에 등록
        DialogManager.Instance.Push(alert);
    }

    public void AddPoint(int point)
    {
        StagePoint += point;
        pointText.text = StagePoint.ToString();
    }

    public void FinishGame() 
    {
        //Application.LoadLevel(Application.loadedLevel); 구 버전 코드 (현재는 쓰지 않습니다.)
        SceneManager.LoadScene("Stage");
    }
}
