using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    enum PanelPosition
    {
        Left,
        Right
    }

    enum PlayerType
    {
        Human,
        Bot
    }
    
    class PlayerPanel : Panel
    {
        public Brain brain;
        int cellW = 20;
        PanelPosition panelPosition;
        PlayerType playerType;
        TurnDelegate tDelegate;
        

        public PlayerPanel(PanelPosition panelPosition, PlayerType playerType,TurnDelegate tDelegate)
        {
            this.panelPosition = panelPosition;
            this.playerType = playerType;
            this.tDelegate = tDelegate;

            Initialize();
            Random rnd1 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd2 = new Random(Guid.NewGuid().GetHashCode());

            /*if (playerType == PlayerType.Human)
            {
                while (brain.stIndex < brain.st.Length - 1)
                {
                    int row = rnd1.Next(0, 10);
                    int column = rnd1.Next(0, 10);
                    string msg = string.Format("{0}_{1}", row, column);
                    brain.Process(msg);
                }
            }*/

            if (playerType == PlayerType.Bot)
            {
                while (brain.stIndex < brain.st.Length - 1)
                {
                    int row = rnd2.Next(0, 10);
                    int column = rnd2.Next(0, 10);
                    string msg = string.Format("{0}_{1}", row, column);
                    brain.isHorizontal = rnd1.Next(0, 40) < 20;
                    brain.Process(msg);

                    
                }
            }
        }

        private void Initialize()
        {
            this.Location = new System.Drawing.Point(cellW + 10, cellW + 10);

            if (panelPosition == PanelPosition.Right)
            {
                this.Location = new System.Drawing.Point(cellW * 10 + cellW + 20, cellW + 10);
            }

            this.BackColor = SystemColors.ActiveCaption;
            this.Size = new System.Drawing.Size(cellW * 10, cellW * 10);

            
            

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Button btn = new Button();
                    btn.Name = i + "_" + j;
                    btn.Click += Btn_Click;
                    btn.MouseEnter += CanPut;
                    btn.MouseLeave += ReplacePos;
                    btn.Size = new Size(cellW, cellW);
                    btn.Location = new Point(i * cellW, j * cellW);
                    this.Controls.Add(btn);

                    
                }
            }

            
            

            brain = new Brain(ChangeButton);
        }
        
        private void ReplacePos(object sender, EventArgs e)
        {
            
            /*Button bn = sender as Button;
            bn.BackColor = Color.White;
            bn.Size = new Size(20, 20);
            bool dir = brain.isHorizontal;
            string[] coordinates = bn.Name.Split('_');
            int ox = int.Parse(coordinates[0]);
            int oy = int.Parse(coordinates[1]);
            int ind;
            ind = ox *10 + oy;
            if (dir)
            {
                if (ind + 1 < 100)
                    Controls[ind + 1].BackColor = Color.White;
                if (ind + 2 < 100)
                    Controls[ind + 2].BackColor = Color.White;
                if (ind + 3 < 100)
                    Controls[ind + 3].BackColor = Color.White;
            }*/
            
        }

        private void CanPut(object sender, EventArgs e)
        {
            
            /*Button bn = sender as Button;
            bn.BackColor = Color.Blue;
            bn.Size = new Size(20, 20);
            string[] coordinates = bn.Name.Split('_');
            int oy = int.Parse(coordinates[0]);
            int ox = int.Parse(coordinates[1]);
            int ind;
            ind = ox * 10 + oy;
            bool dir = brain.isHorizontal;
            if (dir)
            {
                if(oy-1>0 && ind + 1 < 100)
                    Controls[ind + 1].BackColor = Color.Blue;
                if (ind + 2 < 100)
                    Controls[ind + 2].BackColor = Color.Blue;
                if (ind + 3 < 100)
                    Controls[ind + 3].BackColor = Color.Blue;
            }*/
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (brain.stIndex < brain.st.Length - 1)
            {
                brain.Process(btn.Name);
            }
            else
            {
                if (!brain.Process2(btn.Name))
                {
                    tDelegate.Invoke();
                }
            }
        }

        private void ChangeButton(CellState[,] map)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Color colorToFill = Color.White;
                    bool isEnabled = true;
                    if(playerType == PlayerType.Human)
                    {
                        switch (map[i, j])
                        {
                            case CellState.empty:
                                colorToFill = Color.White;
                                break;
                            case CellState.busy:
                                colorToFill = Color.Blue;
                                break;
                            case CellState.striked:
                                colorToFill = Color.Yellow;
                                isEnabled = false;
                                break;
                            case CellState.missed:
                                colorToFill = Color.Gray;
                                isEnabled = false;
                                break;
                            case CellState.aura:
                                colorToFill = Color.White;
                                break;
                            case CellState.killed:
                                colorToFill = Color.Red;
                                isEnabled = false;
                                break;
                            default:
                                break;
                        }
                    }
                    if(playerType == PlayerType.Bot)
                    {
                        switch (map[i, j])
                        {
                            case CellState.empty:
                                colorToFill = Color.White;
                                break;
                            case CellState.busy:
                                colorToFill = Color.White;
                                break;
                            case CellState.striked:
                                colorToFill = Color.Yellow;
                                isEnabled = false;
                                break;
                            case CellState.missed:
                                colorToFill = Color.Gray;
                                isEnabled = false;
                                break;
                            case CellState.aura:
                                colorToFill = Color.White;
                                break;
                            case CellState.killed:
                                colorToFill = Color.Red;
                                isEnabled = false;
                                break;
                            default:
                                break;
                        }
                    }
                    

                    this.Controls[10 * i + j].BackColor = colorToFill;
                    this.Controls[10 * i + j].Enabled = isEnabled;
                }
            }


        }

    }
}
