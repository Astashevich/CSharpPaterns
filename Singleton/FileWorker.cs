namespace Singleton
{
    /// <summary>
    /// Class for working with text. Saving changes to a file.
    /// Executed only on the Save request.
    /// Until then, changes are stored in dynamic memory.
    /// </summary>
    public class FileWorker
    {
        /// <summary>
        /// The path to the recording file.
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// The contents of the file in dynamic memory.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Create a new instance for working with text.
        /// </summary>
        public FileWorker()
        {
            FilePath = "test.txt";
            ReadTextFromFile();
        }

        /// <summary>
        /// Read the content from file.
        /// </summary>
        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath)) Text = "";
            else
            {
                using(var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Append text to file (without saving to permanent memory).
        /// </summary>
        /// <param name="text"> The text to add. </param>
        public void WriteText(string text)
        {
            Text += text;
        }

        /// <summary>
        /// Save text to file.
        /// </summary>
        public void Save()
        {
            using(var writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(Text);
            }
        }
    }
}
