using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class GameOverInfo : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    // Fun facts utama
    private string[] funFacts = {
        "Universitas Katolik Soegijapranata berdiri pada 5 Agustus 1982.",
        "Nama UNIKA diambil dari Mgr. Albertus Soegijapranata, SJ, seorang Pahlawan Nasional.",
        "Sejak 2022, UNIKA juga dikenal dengan nama SCU (Soegijapranata Catholic University).",
        "UNIKA awalnya merupakan Universitas Katolik Atma Jaya Cabang Semarang sebelum berdiri sendiri.",
        "Kampus utama UNIKA berada di Bendan Dhuwur, Semarang.",
        "Pada awal berdirinya, UNIKA memiliki tiga fakultas: Teknik, Hukum, dan Ekonomi.",
        "SCU kini memiliki banyak program studi S1, S2, dan program internasional.",
        "UNIKA menekankan nilai cinta kasih, semangat kebangsaan, keadilan, dan kejujuran.",
        "Rebranding menjadi SCU bertujuan agar nama Soegijapranata semakin dikenal luas.",
        "Moto UNIKA yang terkenal adalah 'Talenta pro Patria et Humanitate'."
    };

    // Menyimpan index yang belum keluar
    private static List<int> availableIndices;

    void Awake()
    {
        // Pastikan infoText tidak null
        if (infoText == null)
        {
            infoText = GetComponentInChildren<TextMeshProUGUI>();
        }

        // Inisialisasi list kalau masih kosong atau null
        if (availableIndices == null || availableIndices.Count == 0)
        {
            ResetFactList();
        }
    }

    void OnEnable()
    {
        if (infoText == null)
        {
            Debug.LogError("⚠ infoText belum diassign di Inspector!");
            return;
        }

        // Reset jika habis
        if (availableIndices == null || availableIndices.Count == 0)
        {
            ResetFactList();
        }

        // Pilih acak dari daftar yang tersisa
        int randomListIndex = Random.Range(0, availableIndices.Count);
        int factIndex = availableIndices[randomListIndex];

        // Tampilkan fact
        infoText.text = funFacts[factIndex];

        // Hapus dari daftar agar tidak repeat
        availableIndices.RemoveAt(randomListIndex);
    }

    void ResetFactList()
    {
        availableIndices = new List<int>();
        for (int i = 0; i < funFacts.Length; i++)
        {
            availableIndices.Add(i);
        }
    }
}
