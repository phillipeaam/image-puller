using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] private InputField[] _urls;
    [SerializeField] private WebImageHolder[] _webImageHolders;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SetTextures();
    }

    private void SetTextures()
    {
        var imgLength = _webImageHolders.Length;
        var urlLength = _urls.Length;

        for (int i = 0; i < imgLength; i++)
        {
            if (i < urlLength)
            {
                var text = _urls[i].text;
                if (!string.IsNullOrEmpty(text))
                {
                    StartCoroutine(TextureDownloader.GetTexture(text, _webImageHolders[i]));
                }
            }
            else break;
        }
    }
}