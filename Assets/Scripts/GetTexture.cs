using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GetTexture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(GetImg());
        this.gameObject.SetActive(false);
    }

    IEnumerator GetImg()
    {
        // https://d1csarkz8obe9u.cloudfront.net/posterpreviews/business-card-design-template-0f8c7ded930e5859b4721c66343dd929.jpg?ts=1591646093
        UnityWebRequest request = UnityWebRequestTexture.GetTexture("https://d1csarkz8obe9u.cloudfront.net/posterpreviews/business-card-design-template-0f8c7ded930e5859b4721c66343dd929.jpg?ts=1591646093");
        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);
        }
        else
        {
            Texture texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            GetComponent<Renderer>().material.mainTexture = texture;
            // GetComponent<Animator>().transform.Rotate(0, 0, 180);
        }
    }
}
