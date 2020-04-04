using System;

namespace BattleShip.Objects {
    public enum OccupationType {
        Empty = 'o',
        Battleship = 'B',
        Cruiser = 'C',
        Destroyer = 'D',
        Submarine = 'S',
        Carrier = 'A',
        
        Hit = 'X',
        Miss = 'M'
    }

    public enum ShotResult {
        Miss, 
        Hit
    }
}