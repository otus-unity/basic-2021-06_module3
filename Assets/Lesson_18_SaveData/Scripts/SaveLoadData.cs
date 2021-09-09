using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadData : MonoBehaviour
{
    public KeyCode saveKeyCode;
    public KeyCode loadKeyCode;
    public GameObject gameObject;

    private SaveLoadRepository saveLoadRepository;

    void Start()
    {
        saveLoadRepository = new SaveLoadRepository(gameObject, SaveLoadRepository.SaveDataType.xmlData);     
    }

    void Update()
    {
        if (Input.GetKeyDown(saveKeyCode)) {
            saveLoadRepository.Save();
        }

        if (Input.GetKeyDown(loadKeyCode)) {
            saveLoadRepository.Load();
        }
    }
}
