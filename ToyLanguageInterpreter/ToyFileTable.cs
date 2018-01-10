using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToyLanguageInterpreter
{
    class ToyFileTable : FileTable
    {
        private static int NEXT_DESCRIPTOR = 1;
        private readonly IDictionary<int, ToyFile> Files = new Dictionary<int, ToyFile>();

        public int openFile(string filename)
        {
            int descriptorToUse = ++NEXT_DESCRIPTOR;
            Files[descriptorToUse] = new ToyFile(filename, descriptorToUse);

            return descriptorToUse;
        }

        public void closeFile(int fileDescriptor)
        {
            if (!Files.ContainsKey(fileDescriptor))
            {
                throw new ToyFileNotFoundException(fileDescriptor);
            }
            Files[fileDescriptor].Close();
            Files.Remove(fileDescriptor);
        }

        public TextReader getFileReader(int fileDescriptor)
        {
            if (!Files.ContainsKey(fileDescriptor))
            {
                throw new ToyFileNotFoundException(fileDescriptor);
            }
            return Files[fileDescriptor].Reader;
        }

        public void closeAllFiles()
        {
            foreach (ToyFile file in Files.Values)
            {
                file.Close();
            }
            Files.Clear();
        }
    }
}