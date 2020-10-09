using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public static class TextureDownloader
{
    public static IEnumerator GetTexture(string url, WebImageHolder holder)
    {
        using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(url))
        {
            request.SetRequestHeader("Access-Control-Expose-Headers", "X-App-Signature");
            
            holder.LoadingView.SetActive(true);
            
            yield return request.SendWebRequest();
            
            holder.LoadingView.SetActive(false);
            
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.LogError($"Error: {request.error}");
            }
            else
            {
                Debug.Log("Download Success!");
                holder.ImageHolder.texture = DownloadHandlerTexture.GetContent(request);
            }
        }
    }
}
