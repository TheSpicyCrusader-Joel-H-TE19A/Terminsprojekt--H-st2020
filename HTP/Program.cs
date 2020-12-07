using System;
using Raylib_cs;
using System.Numerics;


namespace HTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1200, 800, "Most Epic Battles of Hisotry");

            Texture2D BBB = Raylib.LoadTexture("Bling-Bling_Boy.png");

            Texture2D Slayer = Raylib.LoadTexture("DoomSlayer.png");



            // Random RecPosition = new Random();

            float Width = 1200;
            float Height = 800;
            float Speed = 0.5f;
            float Player1X = 1087;
            float Player1Y = 687;
            float Player2X = 90;
            float Player2Y = 687;
            string scene = "Menu";

            Rectangle platform1 = new Rectangle(100, 300, 250, 20);
            Rectangle platform2 = new Rectangle(850, 500, 250, 20);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                if (scene == "Menu")
                {
                    Raylib.ClearBackground(Color.DARKBLUE);
                    Raylib.DrawText("EPIC BATTLES OF HISTORY", 100, 50, 20, Color.WHITE);

                    //Player1X = 1087;
                    //Player1Y = 687;

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "Character Select";
                    }

                }
                else if (scene == "Character Select")
                {
                    Raylib.ClearBackground(Color.DARKBLUE);
                    Raylib.DrawText("Character Selection", 100, 50, 100, Color.WHITE);

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "Arena";
                    }


                }
                else if (scene == "Arena")
                {
                    Raylib.ClearBackground(Color.LIGHTGRAY);
                    if (Player1X == 1087 && Player2X == 90)
                    {
                        Raylib.DrawText("Fight!", 450, 50, 100, Color.WHITE);
                    }

                    Raylib.DrawTextureEx(BBB, new Vector2(Player1X, Player1Y), 0f, 0.25f, Color.WHITE);
                    Raylib.DrawTextureEx(Slayer, new Vector2(Player2X, Player2Y), 0f, 0.25f, Color.WHITE);

                    float xMovement = 0;
                    float yMovement = 0;

                    //Player 1 movements
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && Player1X < Width - 90)
                    {
                        xMovement = Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && Player1X > 0)
                    {
                        xMovement = -Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && Player1Y > 0)
                    {
                        yMovement = -Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && Player1Y < Height - 112.5)
                    {
                        yMovement = Speed;
                    }

                    Player1X += xMovement;
                    Player1Y += yMovement;
                    float xMovement2 = 0;
                    float yMovement2 = 0;

                    //Player 2 movements
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player2X < Width - 90)
                    {
                        xMovement2 = Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player2X > 0)
                    {
                        xMovement2 = -Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player2Y > 0)
                    {
                        yMovement2 = -Speed;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player2Y < Height - 112.5)
                    {
                        yMovement2 = Speed;
                    }

                    Player2X += xMovement2;
                    Player2Y += yMovement2;
                    // if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player2X < Width - 90)
                    // {
                    //     Player2X += Speed;
                    // }

                    // if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player2X > 0)
                    // {
                    //     Player2X -= Speed;
                    // }

                    // if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player2Y > 0)
                    // {
                    //     Player2Y -= Speed;
                    // }

                    // if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player2Y < Height - 112.5)
                    // {
                    //     Player2Y += Speed;
                    // }
                    // if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player2Y < Height - 112.5)
                    // {
                    //     Player2Y += Speed;
                    // }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Menu";
                    }
                    Raylib.DrawRectangleRec(platform1, Color.ORANGE);
                    Raylib.DrawRectangleRec(platform2, Color.PINK);

                    //Kollision

                    if (Raylib.CheckCollisionRecs(platform1, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {

                        Player1X -= xMovement;
                        Player1Y -= yMovement;
                    }

                    if (Raylib.CheckCollisionRecs(platform2, new Rectangle(Player1X, Player1Y, 75, 112)))
                    {

                        Player1X -= xMovement;
                        Player1Y -= yMovement;
                    }

                    if (Raylib.CheckCollisionRecs(platform1, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Player2X -= xMovement2;
                        Player2Y -= yMovement2;

                    }

                    if (Raylib.CheckCollisionRecs(platform2, new Rectangle(Player2X, Player2Y, 75, 112)))
                    {
                        Player2X -= xMovement2;
                        Player2Y -= yMovement2;

                    }


                }



                Raylib.EndDrawing();
            }
        }
    }
}



