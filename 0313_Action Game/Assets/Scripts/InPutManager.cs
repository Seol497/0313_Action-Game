using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField nameInput, aboutInput, powerInput, defenceInput, needLvInput, statusInput;
    public Text nameOutput, aboutOutput, powerOutput, defenceOutput, needLvOutput, statusOutput;
    public Sprite itemSprite, backSprite;
    public Image itemImage, backImage;

    private Dictionary<string, string> nameData = new Dictionary<string, string>();
    private Dictionary<string, string> aboutData = new Dictionary<string, string>();
    private Dictionary<string, string> powerData = new Dictionary<string, string>();
    private Dictionary<string, string> defenceData = new Dictionary<string, string>();
    private Dictionary<string, string> needLvData = new Dictionary<string, string>();
    private Dictionary<string, string> statusData = new Dictionary<string, string>();



    // 저장 버튼을 누르면 입력한 정보를 저장합니다.

    public void SaveNameData()
    {
        string key = "Name";
        string value = nameInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            nameData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }
    public void SaveAboutData()
    {
        string key = "About";
        string value = aboutInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            aboutData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }
    public void SavePowerData()
    {
        string key = "Power";
        string value = powerInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            powerData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }
    public void SaveDefenceData()
    {
        string key = "Defence";
        string value = defenceInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            defenceData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }
    public void SaveNeedLvData()
    {
        string key = "NeedLv";
        string value = needLvInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            needLvData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }
    public void SaveStatusData()
    {
        string key = "Status";
        string value = statusInput.text;

        // 입력한 정보를 Dictionary에 추가합니다.
        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            statusData[key] = value;
            Debug.Log("Data saved: Key = " + key + ", Value = " + value);
        }
        else
        {
            Debug.LogWarning("Key or value is empty!");
        }
    }

    public void LoadData()
    {
        string nameoutput = "";
        string aboutoutput = "";
        string poweroutput = "";
        string defenceoutput = "";
        string needLvoutput = "";
        string statusoutput = "";

        if (nameData.Count == 0 || aboutData.Count == 0 || powerData.Count == 0 || defenceData.Count == 0 || needLvData.Count == 0 || statusData.Count == 0)
        {
            Debug.LogWarning("No data available to load!");
            return;
        }

        foreach (var kvp in nameData)
        {
            nameoutput += kvp.Value + "\n";
        }
        foreach (var kvp in aboutData)
        {
            aboutoutput += kvp.Value + "\n";
        }
        foreach (var kvp in powerData)
        {
            poweroutput += kvp.Key + ": " + kvp.Value + "\n";
        }
        foreach (var kvp in defenceData)
        {
            defenceoutput += kvp.Key + ": " + kvp.Value + "\n";
        }
        foreach (var kvp in needLvData)
        {
            needLvoutput += kvp.Key + ": " + kvp.Value + "\n";
        }
        foreach (var kvp in statusData)
        {
            statusoutput += kvp.Key + ": " + kvp.Value + "\n";
        }
        nameOutput.text = nameoutput;
        aboutOutput.text = aboutoutput;
        powerOutput.text = poweroutput;
        defenceOutput.text = defenceoutput;
        needLvOutput.text = needLvoutput;
        statusOutput.text = statusoutput;
        itemImage.sprite = itemSprite;
        backImage.sprite = backSprite;
    }
        

}
