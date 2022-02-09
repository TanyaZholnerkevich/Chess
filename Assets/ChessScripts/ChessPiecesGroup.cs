using System.Linq;
using UnityEngine;

namespace ChessScripts
{
    [CreateAssetMenu()]
    public class ChessPiecesGroup : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private ChessInfo[] chessPieces;
        
        public string ID => id;

        public string[] GetIds()
        {
            return chessPieces.Select(s => s.ID).ToArray();
        }

        public ChessInfo GetChessInfo(string soundId)
        {
            return chessPieces.FirstOrDefault(s => s.ID == soundId);
        }
    }
}