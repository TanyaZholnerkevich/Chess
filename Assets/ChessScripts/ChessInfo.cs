using UnityEngine;

namespace ChessScripts
{
    [CreateAssetMenu()]
    public class ChessInfo : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private GameObject chessPiece;

        public string ID => id;
        public GameObject ChessPiece => chessPiece;
    }
}