using System;

namespace MarsRover
{
    public class Rover
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        Direction RoverDirection { get; set; }
        Plateau Plateau { get; set; }

        /// <summary>
        ///
        /// </summary>
        public enum Direction
        {
            N = 90,
            E = 180,
            S = 270,
            W = 360
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        /// <param name="plateau"></param>
        public Rover(Int32 x, Int32 y, Direction direction, Plateau plateau)
        {
            PositionX = x;
            PositionY = y;
            RoverDirection = direction;
            Plateau = plateau;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Move()
        {
            if (RoverDirection == Direction.N && Plateau.Y > PositionY)
            {
                PositionY++;
            }
            else if (RoverDirection == Direction.E && Plateau.X > PositionX)
            {
                PositionX++;
            }
            else if (RoverDirection == Direction.S && PositionY > 0)
            {
                PositionY--;
            }
            else if (RoverDirection == Direction.W && PositionX > 0)
            {
                PositionX--;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionCode"></param>
        private void ChangeDirection(Char directionCode)
        {
            if (directionCode == 'L')
                RoverDirection = (RoverDirection - 90) < Direction.N ? Direction.W : RoverDirection - 90;
            else if (directionCode == 'R')
                RoverDirection = (RoverDirection + 90) > Direction.W ? Direction.N : RoverDirection + 90;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="commandStr"></param>
        public void Command(string commandStr)
        {
            foreach (var command in commandStr)
            {
                if (command == 'L' || command == 'R')
                    ChangeDirection(command);
                else if (command == 'M')
                    Move();
            }
        }

        private void ChangeDirection(char command)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public string GetPosition()
        {
            string printedRoverPosition = string.Format("{0} {1} {2}", PositionX, PositionY, RoverDirection);
            Console.WriteLine(printedRoverPosition);
            return printedRoverPosition;
        }
    }
}