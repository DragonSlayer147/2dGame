public class Projectile() {
    int xLast;
    int yLast;
    
    public Projectile(string[,] screen, int x, int y, string dir) : this() {
        if(dir == "right") {
            screen[y, x + 1] = "+";
        }
    }

    public void Logic(string[,] screen, int x, int y, string dir) {
        if(yLast != y || xLast != x) {
                screen[yLast, xLast] = " ";
        }
        screen[y, x] = "+";
        xLast = x;
        yLast = y;

        x++;
    }
}