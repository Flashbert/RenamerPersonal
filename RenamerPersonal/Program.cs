using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenamerPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var file in args)
            {
                if (file.Length > 0 && File.Exists(file))
                {
                    Console.WriteLine(file);
                    Console.WriteLine("New name: " + Path.GetDirectoryName(file) + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_" + Path.GetFileName(file));
                    System.IO.File.Move(file, Path.GetDirectoryName(file) + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_" + Path.GetFileName(file));
                }
            }
            //Console.Read();
        }
    }
}
