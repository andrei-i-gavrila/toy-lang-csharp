namespace ToyLanguageInterpreter
{
    class Close : Statement
    {
        private int FileDescriptor;

        public Close(int fileDescriptor)
        {
            FileDescriptor = fileDescriptor;
        }

        public void Execute(ProgramState state)
        {
            state.FileTable.closeFile(FileDescriptor);
        }
    }
}