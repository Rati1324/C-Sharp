using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Current
{
    public class Garbage
    {
        public int num { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region checked 
            //int x = 2147483647;
            //int y = 3;
            //int res = unchecked(x + y);
            //Console.WriteLine(res);
            #endregion
            #region genrations
            //Garbage G = new Garbage() { num = 1 };
            //Garbage G2 = new Garbage() { num = 3 };
            //GC.Collect();
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(G2));
            //Console.WriteLine(GC.GetGeneration(G));

            #endregion

            #region dipose
            //string fileName = "file.txt";
            //var streamWriter = File.CreateText(fileName);
            //Console.WriteLine(streamWriter.GetType());
            //streamWriter.Dispose();
            //File.Delete(fileName);
            #endregion
            #region dispose
            //string fileName = "file.txt";
            //using (var streamWriter = File.CreateText(fileName))
            //{

            //    streamWriter.Write("text!");
            //}
            //File.Delete(fileName);
            #endregion
            #region finalilzer
            //ExampleClass X = new ExampleClass();

            #endregion
        }

    }
}

