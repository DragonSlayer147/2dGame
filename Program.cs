

// GENERATE SCREEN
//120 by 40 is good!
int screenWidth = 50;
int screenHeight = 10;

string[,] screen = new string[screenHeight, screenWidth];

for(int y = 0; y < screenHeight; y++) {
    for( int x = 0; x < screenWidth; x++) {
        screen[y, x] = " ";
    }
}

static void DrawScreen(string[,] screen, int screenHeight, int screenWidth) {
    Console.Clear();
    int count = 0;

    for(int y = 0; y < screenHeight; y++) {
        Console.Write("|");
        for( int x = 0; x < screenWidth; x++) {
            Console.Write(screen[y, x]);
            count++;
        }
        Console.WriteLine("|");
    }
    //Console.WriteLine(count);
    Thread.Sleep(167);
}




Player player = new Player(screen, 0, 0);

while (true) {
    DrawScreen(screen, screenHeight, screenWidth);
    player.Logic();
}
