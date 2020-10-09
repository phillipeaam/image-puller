using UnityEngine;
using UnityEngine.UI;

public class WebImageHolder : MonoBehaviour
{
    [SerializeField] private RawImage _imageHolder;
    [SerializeField] private GameObject _loadingView;

    public RawImage ImageHolder => _imageHolder;
    public GameObject LoadingView => _loadingView;
}
