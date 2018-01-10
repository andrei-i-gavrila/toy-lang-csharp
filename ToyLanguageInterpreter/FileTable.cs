using System.IO;

namespace ToyLanguageInterpreter
{
    public interface FileTable {

        int openFile(string filename);

        void closeFile(int fileDescriptor);

        TextReader getFileReader(int fileDescriptor);

        void closeAllFiles();
    }
}

