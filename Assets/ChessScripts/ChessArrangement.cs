using System;
using UnityEngine;

namespace ChessScripts
{
    public class ChessArrangement : MonoBehaviour
    {
        [SerializeField] private ChessInfo[] whiteChessInfos;
        [SerializeField] private ChessInfo[] blackChessInfos;
        [SerializeField] private ChessInfo whiteQueen;
        [SerializeField] private ChessInfo blackQueen;
        [SerializeField] private ChessInfo whiteKing;
        [SerializeField] private ChessInfo blackKing;
        [SerializeField] private ChessInfo[] whiteRooks;
        [SerializeField] private ChessInfo[] blackRooks;
        [SerializeField] private ChessInfo[] whiteKnights;
        [SerializeField] private ChessInfo[] blackKnights;
        [SerializeField] private ChessInfo[] whiteBishops;
        [SerializeField] private ChessInfo[] blackBishops;

        private void Start()
        {
            for (int i = 0; i < whiteChessInfos.Length; i++)
            {
                Instantiate(whiteChessInfos[i].ChessPiece, new Vector3(0 + i, 0, 1), Quaternion.identity);
            }
            
            for (int i = 0; i < blackChessInfos.Length; i++)
            {
                Instantiate(blackChessInfos[i].ChessPiece, new Vector3(0 + i, 0, 6), Quaternion.identity);
            }

            Instantiate(whiteQueen.ChessPiece, new Vector3(3, 0, 0), Quaternion.identity);
            Instantiate(blackQueen.ChessPiece, new Vector3(3, 0, 7), Quaternion.identity);
            Instantiate(whiteKing.ChessPiece, new Vector3(4, 0, 0), Quaternion.identity);
            Instantiate(blackKing.ChessPiece, new Vector3(4, 0, 7), Quaternion.identity);
            Instantiate(whiteRooks[0].ChessPiece, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(whiteRooks[1].ChessPiece, new Vector3(7, 0, 0), Quaternion.identity);
            Instantiate(blackRooks[0].ChessPiece, new Vector3(0, 0, 7), Quaternion.identity);
            Instantiate(blackRooks[1].ChessPiece, new Vector3(7, 0, 7), Quaternion.identity);
            Instantiate(whiteKnights[0].ChessPiece, new Vector3(1, 0, 0), Quaternion.identity);
            Instantiate(whiteKnights[1].ChessPiece, new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(blackKnights[0].ChessPiece, new Vector3(1, 0, 7), Quaternion.identity);
            Instantiate(blackKnights[1].ChessPiece, new Vector3(6, 0, 7), Quaternion.identity);
            Instantiate(whiteBishops[0].ChessPiece, new Vector3(2, 0, 0), Quaternion.identity);
            Instantiate(whiteBishops[1].ChessPiece, new Vector3(5, 0, 0), Quaternion.identity);
            Instantiate(blackBishops[0].ChessPiece, new Vector3(2, 0, 7), Quaternion.identity);
            Instantiate(blackBishops[1].ChessPiece, new Vector3(5, 0, 7), Quaternion.identity);
        }
    }
}