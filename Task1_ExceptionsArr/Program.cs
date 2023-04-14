using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ExceptionsArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Boolean DirEx = false;
                string str="";
                ExceptionArr exceptionArr = new ExceptionArr(str);
                //HumanException humanException = new HumanException();
                FilesAndDir filesAndDir = new FilesAndDir();
                Console.WriteLine("Введите путь к директори:");
                filesAndDir.DirPath = Console.ReadLine();
                DirEx = filesAndDir.DirExist();

                if (DirEx)
                {
                    filesAndDir.DelPathAndDir();
                    Console.WriteLine("Удалены папки и файлы в директории {0}", filesAndDir.DirPath);

                }
                else
                {
                    exceptionArr.GetBaseException("sdfasdfsd");
                }


            }
            catch (FormatException) 
            {
            }
            catch (ArgumentException)
            { 
            }
            catch (DriveNotFoundException)
            {
            }
            catch (DivideByZeroException)
            {
            }
            catch (FileNotFoundException)
            {
            }

            finally
            { 
            
             }
        }
    }
}



