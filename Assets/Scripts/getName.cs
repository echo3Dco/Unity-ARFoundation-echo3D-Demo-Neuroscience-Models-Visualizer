using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
using SimpleJSON;

// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class getName : MonoBehaviour
{
    public string APIKey = "<YOUR_API_KEY>";
    public string objectKey = "<OBJECT_Key>";
    private string src = "UnitySDK";
    private string endpointURL;
    private string serverURL;
    private TMP_Text m_TextComponent;

    void Start()
    {
        endpointURL = "https://api.echo3D.co";
        serverURL = endpointURL + "/get?key=" + APIKey + "&src=" + src + "&entry=" + objectKey + "&data=name";
        // serverURL = "https://api.echo3d.co/get?key=dry-thunder-6513&entry=ec4c4005-3412-4fc8-8a59-52e52bd3a8c8&data=name";
        // A correct website page.
        StartCoroutine(GetRequest(serverURL, GetComponent<TMP_Text>()));

        // m_TextComponent = GetComponent<TMP_Text>();
    }

    IEnumerator GetRequest(string uri, TMP_Text TextComponent)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                TextComponent.text = webRequest.downloadHandler.text;
            }
        }
    }
}