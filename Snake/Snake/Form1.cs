using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Snake.Settings;

namespace Snake
{
    public partial class form1 : Form
    {
        private List<Cercle> Snake = new List<Cercle>();
        private Cercle food = new Cercle();
        public int comptador = 0;

        public form1()
        {
            InitializeComponent();
            //Inicialitzem l'estat inicial
            new Settings();

            //Inicialitzem el timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start new game
            StartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame()
        {
            //Settings a Default
            new Settings();

            //Creem un nou objecte jugador
            Snake.Clear();
            Cercle head = new Cercle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblPuntuacio.Text = Settings.Score.ToString();
            lbl_velocitat.Text = Settings.Speed.ToString();
            GenerateFood();

        }

        private void GenerateFood()
        {
            //Creem menjar a una posició random
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random r = new Random();
            food = new Cercle();
            food.X = r.Next(0, maxXPos);
            food.Y = r.Next(0, maxYPos);
        }

        private void SumarPunts()
        {
            Settings.Score += 100;
            lblPuntuacio.Text = Settings.Score.ToString();

            GenerateFood();
            Cercle tail = new Cercle();
            tail.X = Snake[Snake.Count - 1].X;
            tail.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(tail);
            Settings.Speed += 1;
            gameTimer.Interval = 1000 / Settings.Speed;
            lbl_velocitat.Text = Settings.Speed.ToString();

        }

        private void UpdateScreen(Object sender, EventArgs e)
        {
            //mirem si el joc ha acabat
            if (Settings.GameOver)
            {
                //Mirem si apretem l'Enter
                if (Input.KeyPressed(Keys.Enter))
                {
                    lbl_final.Text = "";
                    txt_reiniciar.Text = "";
                    //Tornem a jugar
                    StartGame();
                }
    
            }

            else//Mirem quin moviment fem
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                if (Input.KeyPressed(Keys.Escape))
                {
                    GameOver = true;
                    lbl_final.Text = "Has sortit del joc!! Puntuació: " + Settings.Score;
                    txt_reiniciar.Text = "Clica Enter per tornar a jugar";
                }

                int i = 1;
                while (i < Snake.Count)
                {
                    if (Snake.Count > 1)
                    {
                        if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y)
                        {
                            GameOver = true;
                            lbl_final.Text = "Has perdut!! Puntuació: " + Settings.Score;
                            txt_reiniciar.Text = "Clica Enter per tornar a jugar";
                        }
                    }
                    i++;
                }

                MovePlayer();
            }
            pbCanvas.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush[] colors = new Brush[7];
            colors[0] = Brushes.Red;
            colors[1] = Brushes.Blue;
            colors[2] = Brushes.Green;
            colors[3] = Brushes.Chocolate;
            colors[4] = Brushes.Cyan;
            colors[5] = Brushes.Pink;
            colors[6] = Brushes.Orange;

            if ( comptador > 6)
            {
                comptador = 0;
            }


            if (!Settings.GameOver)
            {
                
                //Pintem la serp
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Assignem el color de la serp
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;    //Draw head
                    else
                        snakeColour = colors[comptador];    //Rest of body


                    //Dibuixem cada boleta
                    canvas.FillRectangle(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                    //Dibuixem el menjar
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));
            
                }
            }
            
        }

        private void MovePlayer()
    	{
 	       for (int i = Snake.Count - 1; i >= 0; i--)
        	{
                //Move head
                if (i == 0)
                {
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        SumarPunts();
                        comptador++;
                    }

                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;
                    
                    if (Snake[i].X <= 0 || Snake[i].Y <= 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        GameOver = true;
                        lbl_final.Text = "Has perdut!! Puntuació: " + Settings.Score;
                        txt_reiniciar.Text = "Clica Enter per tornar a jugar";

                    }

                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                }

                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
 
            }
    	}


    }
}
