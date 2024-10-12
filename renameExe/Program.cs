using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace renameExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напиши какой файл хочешь переименовать(введи полный путь): ");
            string path = Console.ReadLine();
            Console.WriteLine("теперь пиши какое название ты хочешь дать новому файлу(указывая *.exe и тд): ");
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                string newPath = $"{fileInfo.Directory}\\{Console.ReadLine()}";
                
                FileInfo fileInfo1 = new FileInfo(newPath);

                fileInfo1.Create();
                fileInfo.Delete();
                Console.WriteLine("Переименование завершено успешно!");
            }catch (Exception ex)
            {
                Console.WriteLine($"Oh... We have some problems - {ex.Message}. srry");
            }
            /*if (fileInfo.Exists)
            {
                Console.WriteLine($"name of file {fileInfo.Directory}");
                Console.WriteLine($"time of creating {fileInfo.CreationTimeUtc}");
                Console.WriteLine($"size - {fileInfo.Length}");
            }*/
        }
    }
}
