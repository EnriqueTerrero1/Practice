using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    internal class WRfile
    {
        public void  ReadFile() {

            try
            {
                StreamReader streamReader = new StreamReader(@"C:\Users\enriq\Documents\BookC#\Practice\archivo.txt");
                Console.Write(streamReader.ReadToEnd());

                streamReader.Close();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) { 
            Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
           
            
                }
    }
}
