using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;

public class Window_Graph : MonoBehaviour
{

    public admin ad;
    public admin adminis;
    private List<int> px1;
    private List<int> px2;
    private List<int> pY1;
    private List<int> pY2;
    private List<int> pZ1;
    private List<int> pZ2;

    private List<int> t;
    private List<int> t2;

    [SerializeField]private Sprite circleSpriteR;
    [SerializeField] private Sprite circleSpriteG;
    [SerializeField] private Sprite circleSpriteB;
    [SerializeField] private Sprite circleSpriteP;
    [SerializeField] private Sprite circleSpriteY;
    [SerializeField] private Sprite circleSpriteF;
    private RectTransform graphContainer;

    private void Start()
    {
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        ad.begin();
        adminis.begin();
    }

    void Update()
    {
        
        px1 = ad.posX1;
        pY1 = ad.posY1;
        pZ1 = ad.posZ1;
        px2 = adminis.posX2;
        pY2 = adminis.posY2;
        pZ2 = adminis.posZ2;
        t = ad.times1;
        t2 = adminis.times2;
    }

    public void doGraphs1() {
        ShowGraphR(t, px1);
        ShowGraphG(t, pY1);
        ShowGraphB(t, pZ1);
    }

    public void doGraphs2()
    {
        ShowGraphF(t2, pZ2);
        ShowGraphP(t2, px2);
        ShowGraphY(t2, pY2);
    }

    private GameObject createCircleR(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteR;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private GameObject createCircleG(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteG;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private GameObject createCircleB(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteB;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private GameObject createCircleF(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteF;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private GameObject createCircleP(Vector2 anchoredPosition)
    {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteP;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }
    
    private GameObject createCircleY(Vector2 anchoredPosition)
    {

        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSpriteY;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11, 11);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    public void ShowGraphR(List<int> listaT, List<int> listaP) {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++) {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleR(new Vector2(time, posX));
            if (lastCircle != null) {
                createDotConnectionR(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    public void ShowGraphG(List<int> listaT, List<int> listaP)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++)
        {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleG(new Vector2(time, posX));
            if (lastCircle != null)
            {
                createDotConnectionG(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    public void ShowGraphB(List<int> listaT, List<int> listaP)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++)
        {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleB(new Vector2(time, posX));
            if (lastCircle != null)
            {
                createDotConnectionB(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    public void ShowGraphP(List<int> listaT, List<int> listaP)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++)
        {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleP(new Vector2(time, posX));
            if (lastCircle != null)
            {
                createDotConnectionP(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    public void ShowGraphY(List<int> listaT, List<int> listaP)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++)
        {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleY(new Vector2(time, posX));
            if (lastCircle != null)
            {
                createDotConnectionR(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    public void ShowGraphF(List<int> listaT, List<int> listaP)
    {
        float graphHeight = graphContainer.sizeDelta.y;
        float graphWidth = graphContainer.sizeDelta.x;
        float timeSize = 20f;
        float dataSize = 200f;

        GameObject lastCircle = null;
        for (int i = 0; i < listaT.Count; i++)
        {
            float time = ((listaT[i] / timeSize) * graphWidth) + 10;
            float posX = ((listaP[i] / dataSize) * graphHeight) + 10;
            GameObject circle = createCircleF(new Vector2(time, posX));
            if (lastCircle != null)
            {
                createDotConnectionF(lastCircle.GetComponent<RectTransform>().anchoredPosition, circle.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircle = circle;
        }
    }

    private void createDotConnectionR(Vector2 dotPosA, Vector2 dotPosB) {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(184, 0, 0, 255);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void createDotConnectionG(Vector2 dotPosA, Vector2 dotPosB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(0, 122, 0, 255);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void createDotConnectionB(Vector2 dotPosA, Vector2 dotPosB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(0, 0, 178, 255);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void createDotConnectionP(Vector2 dotPosA, Vector2 dotPosB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(79, 0, 164, 255);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void createDotConnectionY(Vector2 dotPosA, Vector2 dotPosB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(255, 181, 0, 255);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }

    private void createDotConnectionF(Vector2 dotPosA, Vector2 dotPosB)
    {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color32(245, 66, 0, 214);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPosB - dotPosA).normalized;
        float distance = Vector2.Distance(dotPosA, dotPosB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(50, 3f);
        rectTransform.anchoredPosition = dotPosA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVectorFloat(dir));
    }
}
