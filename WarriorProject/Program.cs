/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    public class Position
    {
        private int _x;
        private int _y;

        public int X { get => _x; }
        public int Y { get => _y; }
        public Position(int x, int y)
        {
            _x= x;
            _y = y;
        }
        public void ToConsole()
        {
            Console.WriteLine($"({_x}, {_y})");
        }
    }
    public class Warrior
    {
        private string _name;
        private Position _position;
        public Warrior(string name, Position position) 
        {
            _name = name;
            _position = position;
        }
        public void MoveHorizontal(int distance)
        {
            _position.X = _position.X + distance;

        }
        public void MoveVertical(int distance)
        {
            _position.Y = _position.Y + distance;
        }
        public void ToConsole()
        {
            Console.WriteLine($"{_name}, position ({_position})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
