using System;

namespace snakeGame
{
    public class Class1
    {

    }
    public class Pos
    {
        public int x, y;
    }
    public class Playa
    {
        public Pos pos { get; set; }
    }
    public class Obstake
    {

        public int Class { get; set; }
        public Pos Pos { get; set; }
        // ?

        public ConsoleColor ObstacleColor { get; set; }
    }
}
