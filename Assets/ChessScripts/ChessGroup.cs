using System.Linq;
using DefaultNamespace;
using UnityEngine;

namespace ChessScripts
{
    [CreateAssetMenu()]
    public class ChessGroup : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private ChessPiecesGroup[] chessPiecesGroup;
        
        public string ID => id;
        
        public string[] GetIds()
        {
            return chessPiecesGroup.Select(s => s.ID).ToArray();
        }

        public string[] GetGroupsIds()
        {
            return chessPiecesGroup.Select(s => s.ID).ToArray();
        }

        public string[] GetChessIds(string groupId)
        {
            var group = chessPiecesGroup.FirstOrDefault(s => s.ID == groupId);
            return group == null ? null : group.GetIds();
        }

        public ChessInfo GetChessInfo(string id)
        {
            foreach (var chessGroup in chessPiecesGroup)
            {
                var chessPiece = chessGroup.GetChessInfo(id);
                if (chessPiece != null)
                {
                    return chessPiece;
                }
            }

            return null;
        }
    }
}