using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace MySnake
{
    class Serial
    {
        static Serial()
        {

        }

        public void f1(Snake sn)
        {
            FileStream fs = new FileStream(@"data1.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,sn);
            fs.Close();
           

        }

        public Snake f2()
        {
            FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Snake snake1 = bf.Deserialize(fs) as Snake;
            fs.Close();
            return snake1;

        }
        public void f3(Wall wall)
        {
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, wall);
            fs.Close();

        }
        public Wall f4()
        {
            FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Wall wall = bf.Deserialize(fs) as Wall;
            fs.Close();
            return wall;
        }
    }
}
