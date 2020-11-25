﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazingCheckers.Server.Data.Entities
{
    public class Capture : IEntity
    {
        public object PK => new { MoveId, PieceId };

        public int MoveId { get; set; }
        public Move Move { get; set; }

        public int PieceId { get; set; }
        public GamePiece Piece { get; set; }
    }
}