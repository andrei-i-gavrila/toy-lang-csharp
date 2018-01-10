using System;
using System.IO;

namespace ToyLanguageInterpreter
{
    public class ToyFile
    {
        private string Filename;
        private int DescriptorToUse;
        public TextReader Reader;


        public ToyFile(string filename, int descriptorToUse)
        {
            Filename = filename;
            DescriptorToUse = descriptorToUse;
            try
            {
                Reader = new StreamReader(filename);
            }
            catch (Exception)
            {
                throw new ToyCannotOpenFileException(filename);
            }
        }

        public void Close()
        {
            Reader.Close();
        }
    }
}