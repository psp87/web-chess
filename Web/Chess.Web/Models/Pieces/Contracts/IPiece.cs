﻿namespace Chess.Services.Data.Models.Pieces.Contracts
{
    using System;

    using Chess.Common.Enums;
    using Chess.Web.Models;

    public interface IPiece : ICloneable
    {
        string Name { get; }

        Color Color { get; }

        char Symbol { get; }

        Position Position { get; set; }

        bool IsFirstMove { get; set; }

        bool IsLastMove { get; set; }

        bool IsMovable { get; set; }

        public int Points { get; }

        void IsMoveAvailable(Square[][] matrix);

        void Attacking(Square[][] matrix);

        bool Move(Position toPosition, Square[][] boardMatrix, int turn, Move move);

        bool Take(Position toPosition, Square[][] boardMatrix, int turn, Move move);
    }
}
