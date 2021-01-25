using System;
using Raylib_cs;
using System.Numerics;


namespace HTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1900, 900, "Möst Epic Battles of Hisotry B)");

            Texture2D BBB = Raylib.LoadTexture("Bling-Bling_Boy.png");

            Texture2D Slayer = Raylib.LoadTexture("DoomSlayer.png");

            Texture2D Troll = Raylib.LoadTexture("Trollface.png");
            // Random generator = new Random();



            float Width = 1900;
            float Height = 900;
            float Speed1 = 1f;
            float Speed2 = 1f;
            int BallVelocityX = 1;
            int BallVelocityY = 1;
            float Player1X = 1750;
            float Player1Y = 687;
            float Player2X = 150;
            float Player2Y = 687;
            int ballx = (int)Math.Round(Width / 2);
            int bally = (int)Math.Round(Height / 2);
            int ballspeedx = 3;
            int ballspeedy = 3;
            string Player1 = "Alive";
            string Player2 = "Alive";
            string scene = "Menu";
            // string Player1 = "Player1";
            // string Player2 = "Player2";
            // int Player1HP = 200;
            // int Player2HP = 200;

            // Random PlayerDMG = new Random();



            Rectangle Ability1 = new Rectangle(200, 450, 25, 25);
            Rectangle Ability2 = new Rectangle(Width / 2, 800, 25, 25);
            Rectangle Ability3 = new Rectangle(1700, 450, 25, 25);
            Rectangle Ability4 = new Rectangle(Width / 2, 100, 25, 25);
            Rectangle Ability5 = new Rectangle(0, 0, 25, 25);
            Rectangle Ability6 = new Rectangle(Width - 25, 0, 25, 25);
            Rectangle Ability7 = new Rectangle(0, Height - 25, 25, 25);
            Rectangle Ability8 = new Rectangle(Width - 25, Height - 25, 25, 25);
            Rectangle troll = new Rectangle(ballx, bally, 60, 112);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                if (scene == "Menu")
                {
                    Raylib.ClearBackground(Color.DARKBLUE);
                    Raylib.DrawText("Survive Le Trollage", 250, 100, 125, Color.WHITE);
                    Raylib.DrawText("Press ENTER to begin", 600, 300, 50, Color.BLACK);
                    Raylib.DrawText("Player 1", 1400, 600, 80, Color.WHITE);
                    Raylib.DrawText("Player 2", 100, 600, 80, Color.WHITE);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "Arena";
                    }

                }
                else if (scene == "Arena")
                {
                    Raylib.ClearBackground(Color.LIGHTGRAY);
                    if (Player1X == 1830 && Player2X == 90 && Player1Y == 687 && Player2Y == 687)
                    {
                        Raylib.DrawText("BEGIN!", 775, 350, 100, Color.WHITE);
                    }

                    // Raylib.DrawText($"{Player2} HP: {Player2HP}", 975, 50, 25, Color.WHITE);
                    // Raylib.DrawText($"{Player1} HP: {Player1HP}", 200, 50, 25, Color.WHITE);


                    Raylib.DrawTextureEx(BBB, new Vector2(Player1X, Player1Y), 0f, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(Slayer, new Vector2(Player2X, Player2Y), 0f, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(Troll, new Vector2(troll.x, troll.y), 0F, 0.25f, Color.WHITE);

                    // int Player1DMG = PlayerDMG.Next(1, 50);
                    // int Player2DMG = PlayerDMG.Next(1, 20);

                    float xMovement = 0;
                    float yMovement = 0;

                    //Player 1 movements
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && Player1X < Width - 90)
                    {
                        xMovement = Speed1;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && Player1X > 0)
                    {
                        xMovement = -Speed1;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && Player1Y > 0)
                    {
                        yMovement = -Speed1;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && Player1Y < Height - 112.5)
                    {
                        yMovement = Speed1;
                    }

                    Player1X += xMovement;
                    Player1Y += yMovement;
                    // player1hurtbox.x += xMovement;
                    // player1hurtbox.y += yMovement;
                    //Player 2 movements
                    float xMovement2 = 0;
                    float yMovement2 = 0;


                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player2X < Width - 90)
                    {
                        xMovement2 = Speed2;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player2X > 0)
                    {
                        xMovement2 = -Speed2;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player2Y > 0)
                    {
                        yMovement2 = -Speed2;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player2Y < Height - 112.5)
                    {
                        yMovement2 = Speed2;
                    }

                    Player2X += xMovement2;
                    Player2Y += yMovement2;

                    //Troll movements
                    troll.x += BallVelocityX * ballspeedx;
                    troll.y += BallVelocityY * ballspeedy;

                    if (troll.x + 45 > Width)
                    {
                        BallVelocityX = BallVelocityX * -1;
                    }
                    else if (troll.x + 45 < 0)
                    {
                        BallVelocityX = BallVelocityX * -1;
                    }
                    if (troll.y + 45 > Height)
                    {
                        BallVelocityY = BallVelocityY * -1;
                    }
                    if (troll.y + 45 < 0)
                    {
                        BallVelocityY = BallVelocityY * -1;
                    }



                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Menu";
                    }
                    Raylib.DrawRectangleRec(Ability1, Color.ORANGE);
                    Raylib.DrawRectangleRec(Ability2, Color.PINK);
                    Raylib.DrawRectangleRec(Ability3, Color.BLUE);
                    Raylib.DrawRectangleRec(Ability4, Color.GREEN);
                    Raylib.DrawRectangleRec(Ability5, Color.RED);
                    Raylib.DrawRectangleRec(Ability6, Color.YELLOW);
                    Raylib.DrawRectangleRec(Ability7, Color.PURPLE);
                    Raylib.DrawRectangleRec(Ability8, Color.BROWN);

                    //Kollision

                    //Ability1
                    if (Raylib.CheckCollisionRecs(Ability1, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        ballspeedx = 1;
                    }

                    if (Raylib.CheckCollisionRecs(Ability1, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        ballspeedx = 1;
                    }

                    //Ability2
                    if (Raylib.CheckCollisionRecs(Ability2, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        ballspeedy = 1;
                    }

                    if (Raylib.CheckCollisionRecs(Ability2, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        ballspeedy = 1;
                    }

                    //Ability3
                    if (Raylib.CheckCollisionRecs(Ability3, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        ballspeedx = 3;
                    }

                    if (Raylib.CheckCollisionRecs(Ability3, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        ballspeedx = 3;
                    }

                    //Ability4
                    if (Raylib.CheckCollisionRecs(Ability4, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        ballspeedy = 3;
                    }

                    if (Raylib.CheckCollisionRecs(Ability4, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        ballspeedy = 3;
                    }

                    //Ability5
                    if (Raylib.CheckCollisionRecs(Ability5, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        Speed2 = 1.50f;
                    }

                    if (Raylib.CheckCollisionRecs(Ability5, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Speed2 = 1.50f;
                    }

                    //Ability6
                    if (Raylib.CheckCollisionRecs(Ability6, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        Speed1 = 1.50f;
                    }
                    if (Raylib.CheckCollisionRecs(Ability6, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Speed1 = 1.50f;
                    }

                    //Ability7
                    if (Raylib.CheckCollisionRecs(Ability7, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        Speed1 = 0.50f;
                    }
                    if (Raylib.CheckCollisionRecs(Ability7, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Speed1 = 0.50f;
                    }

                    //Ability8
                    if (Raylib.CheckCollisionRecs(Ability8, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        Speed2 = 0.50f;
                    }
                    if (Raylib.CheckCollisionRecs(Ability8, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Speed2 = 0.50f;
                    }
                    //if death

                    if (Raylib.CheckCollisionRecs(troll, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {
                        Player1 = "Dead";
                    }

                    if (Raylib.CheckCollisionRecs(troll, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Player2 = "Dead";
                    }

                    if (Player1 == "Dead" || Player2 == "Dead")
                    {
                        scene = "Game Over";
                    }
                }
                else if (scene == "Game Over")
                {
                    Raylib.ClearBackground(Color.YELLOW);
                    if (Player1 == "Dead")
                    {
                        Raylib.DrawText("Player 2 aka Doomslayer survived the longest", 550, 100, 50, Color.BLACK);
                        Raylib.DrawText("Press TAB to return to menu", 700, 225, 25, Color.BLACK);
                        Raylib.DrawText("Press SPACE to play again", 700, 325, 25, Color.BLACK);
                    }
                    if (Player2 == "Dead")
                    {
                        Raylib.DrawText("Player 1 aka Bling Bling Boy survived the longest", 550, 100, 50, Color.BLACK);
                        Raylib.DrawText("Press TAB to return to menu", 700, 225, 25, Color.BLACK);
                        Raylib.DrawText("Press SPACE to play again", 700, 325, 25, Color.BLACK);
                    }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Menu";
                    }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = "Arena";
                        Player1 = "Alive";
                        Player2 = "Alive";
                        troll.x = (int)Math.Round(Width / 2);
                        troll.y = (int)Math.Round(Height / 2);
                        Player1X = 1830;
                        Player1Y = 687;
                        Player2X = 90;
                        Player2Y = 687;
                        ballspeedx = 3;
                        ballspeedy = 3;
                        BallVelocityX = 1;
                        BallVelocityY = 1;
                        Speed1 = 1f;
                        Speed2 = 1f;
                    }

                }
                Raylib.EndDrawing();


            }




        }
    }
}





