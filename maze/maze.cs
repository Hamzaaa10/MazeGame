using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class maze
    {
        private int _width;
        private int _height;
        private player _player;
        private Imazeobject[,] _MazeobjectArry;
        public maze(int width ,int hight)
        {
            _height = hight;    
            _width = width;
            _MazeobjectArry = new Imazeobject[_width ,_height];
            _player = new player() { x = 1 , y = 1};
        }
        public void drawmaze()
        {
            Console.Clear();    
            for (int i = 0; i < _height ; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (i==_height-1 && j==_width)
                    {
                        _MazeobjectArry[j, i] = new space();
                        Console.Write(_MazeobjectArry[j, i].Icon);
                    }
                    else if (i == 0 || j == 0 || i==_height - 1  || j == _width - 1 )
                    {
                        _MazeobjectArry[j , i] = new Wall();
                        Console.Write(_MazeobjectArry[j , i].Icon);
                    }
                    else if(j==_player.x && i == _player.y)
                    {
                        Console.Write(_player.Icon);    
                    }
                    else if (j%3==0&&i%3==0|| (j%5==0&&i%2==0))
                    {
                      _MazeobjectArry[j, i] = new Wall();
                      Console.Write(_MazeobjectArry[j, i].Icon);
                    }
                    else
                    {
                        _MazeobjectArry[j, i] = new space();
                        Console.Write(_MazeobjectArry[j, i].Icon);
                    }
                }
                Console.WriteLine();

            }
        }
        public void move()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            ConsoleKey key = input.Key;

            switch (key) 
            {
                case ConsoleKey.UpArrow :
                    updatepos(0, -1);
                    break;
                case ConsoleKey.DownArrow :
                    updatepos(0, 1);
                    break;
                case ConsoleKey.LeftArrow :
                    updatepos(-1, 0);
                    break;
                case ConsoleKey.RightArrow :
                    updatepos(1 , 0);
                    break;
            }
        }

        public void updatepos(int dx, int dy) {
            int newx = _player.x + dx;
            int newy = _player.y + dy;
            if (newx <= _width && newx >= 0 && newy <= _height && newy >= 0 && _MazeobjectArry[ newx , newy].Solid==false) {
                _player.x = newx;
                _player.y = newy;
                drawmaze();
            }
        }
        



    
    }

}
