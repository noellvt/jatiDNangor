using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float sisaWaktu;
    // Update is called once per frame
    void Update()
    {
        sisaWaktu = sisaWaktu - Time.deltaTime;
        int menit = Mathf.FloorToInt(sisaWaktu / 60);
        int detik = Mathf.FloorToInt(sisaWaktu % 60);
        timerText.text = string.Format("{0:00}:{1:00}", menit, detik);
    }
}
