namespace ApplePie.Core
{
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class Core : MonoBehaviour
    {
        [SerializeField] private TMP_InputField m_redPlayerWord;

        [SerializeField] private TMP_InputField m_bluePlayerWord;

        [SerializeField] private TextMeshProUGUI m_targetWord;

        private void Start ()
        {
            string randomWord = $"RANDOM";

            m_targetWord.text = randomWord;

            m_redPlayerWord.SetTextWithoutNotify("");
            m_bluePlayerWord.SetTextWithoutNotify("");

            m_redPlayerWord.ActivateInputField();
        }
    }
}