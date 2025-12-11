using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateSettings : MonoBehaviour
{
    void Awake()
    {
        QualitySettings.vSyncCount = 0;

        // 2. Set target FPS ke 60
        Application.targetFrameRate = 60;
    }
}
