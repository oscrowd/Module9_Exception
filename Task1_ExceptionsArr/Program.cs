using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //Boolean DirEx = false;
                int i;
                int j;
                int k;

                j = 1;
                k = 0;

                i = j / k;

                //FilesAndDir filesAndDir = new FilesAndDir();
                //Console.WriteLine("Введите путь к директори:");
                //filesAndDir.DirPath = Console.ReadLine();
                //filesAndDir.DelPathAndDir();
                //Console.WriteLine("Удалены папки и файлы в директории {0}", filesAndDir.DirPath);
                //DirEx = filesAndDir.DirExist();

                var fi = new FileInfo("d:\\test1\\Students333.dat");
                fi.Delete();
                Console.WriteLine("Удален файл");
                Console.ReadLine();

            }
            catch (FormatException) 
            {
                throw new ExceptionMessage("Jib,rf ajhvfnf");
            }
            catch (ArgumentException)
            {
                throw new ExceptionMessage("Ошибка аргумента");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                throw new ExceptionMessage("Папки такой нет!");
            }
            catch (System.DivideByZeroException)
            {
                throw new ExceptionMessage("На ноль делить нельзя");
            }
            catch (FileNotFoundException)
            {
                throw new ExceptionMessage("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла неизвестная ошибка");
            }
            finally
            {
                Console.WriteLine("Всн нормально, продолжаем!");
                Console.ReadLine();
            }
        }
    }
}



