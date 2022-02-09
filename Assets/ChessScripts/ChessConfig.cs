using System.Linq;
using DefaultNamespace;
using UnityEngine;

namespace ChessScripts
{
    [CreateAssetMenu()]
    public class ChessConfig : ScriptableObject
    {
        [SerializeField] private ChessGroup[] groups;
        
        public string[] GetGroupsIds()
        {
            return groups.Select(s => s.ID).ToArray();
        }

        public string[] GetChessIds(string groupId)
        {
            var group = groups.FirstOrDefault(s => s.ID == groupId);
            return group == null ? null : group.GetIds();
        }

        public ChessInfo GetChessInfo(string id)
        {
            foreach (var chessGroup in groups)
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