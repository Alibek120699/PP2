using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum ShipType
    {
        D1,
        D2,
        D3,
        D4
    }
    class Ship
    {
        public List<ShipPoint> body = new List<ShipPoint>();
        public ShipType type;
        public int gameobjects = 0;

        public Ship(Point p, ShipType type, bool isHorizontal)
        {
            this.type = type;
            GenerateBody(p, isHorizontal);
        }

        public void GenerateBody(Point p, bool isHorizontal)
        {
            if (isHorizontal)
            {
                switch (type)
                {
                    case ShipType.D1:
                        body.Add(new ShipPoint { X = p.X, Y = p.Y, PType = PartType.ShipPart });
                        gameobjects++;
                        break;
                    case ShipType.D2:
                        for (int i = 0; i < 2; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X + i, Y = p.Y, PType = PartType.ShipPart });
                            gameobjects++;
                        }
                        break;
                    case ShipType.D3:
                        for (int i = 0; i < 3; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X + i, Y = p.Y, PType = PartType.ShipPart });
                            gameobjects++;
                        }
                        break;
                    case ShipType.D4:
                        for (int i = 0; i < 4; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X + i, Y = p.Y, PType = PartType.ShipPart });
                            gameobjects++;
                        }
                        break;
                    default:
                        break;
                }
            }

            else
            {
                switch (type)
                {
                    case ShipType.D1:
                        body.Add(new ShipPoint { X = p.X, Y = p.Y, PType = PartType.ShipPart });
                        break;
                    case ShipType.D2:
                        for (int i = 0; i < 2; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X, Y = p.Y + i, PType = PartType.ShipPart });
                        }
                        break;
                    case ShipType.D3:
                        for (int i = 0; i < 3; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X, Y = p.Y + i, PType = PartType.ShipPart });
                        }
                        break;
                    case ShipType.D4:
                        for (int i = 0; i < 4; ++i)
                        {
                            body.Add(new ShipPoint { X = p.X, Y = p.Y + i, PType = PartType.ShipPart });
                        }
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
