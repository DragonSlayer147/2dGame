public class Player(string[,] screen, int x, int y) {
    int xLast;
    int yLast;
    bool arrowInit = false;
    bool arrow = false;


    public void Logic() {
        if(yLast != y || xLast != x) {
            screen[yLast, xLast] = " ";
            }
        screen[y, x] = "0";
        xLast = x;
        yLast = y;
        //x++;
        

        if(Console.KeyAvailable) {
            switch(Console.ReadKey(true).Key) {
                case ConsoleKey.W: {
                    if(y - 1 >= 0) {
                        y--;
                    }
                    break;
                }
                case ConsoleKey.A: {
                    if(x - 1 >= 0) {
                        x--;
                    }
                    break;
                }
                case ConsoleKey.S: {
                    if(y + 1 < screen.GetLength(0)) {
                        y++;
                    }
                    break;
                }
                case ConsoleKey.D: {
                    if(x + 1 < screen.GetLength(1)) {
                        x++;
                    }
                    break;
                }


                case ConsoleKey.RightArrow: {
                    new Projectile(screen, x, y, "right");
                    break;
                }
            }
        }
    }

}