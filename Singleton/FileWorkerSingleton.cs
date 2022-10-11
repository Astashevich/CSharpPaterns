namespace Singleton
{
    /// <summary>
    /// Class for working with text. Saving changes to a file
    /// executed only on the Save request.
    /// Until then, changes are stored in dynamic memory.
    /// Implementation of the Singleton pattern.
    /// </summary>
    public class FileWorkerSingleton
    {
        /// <summary>
        /// A private static field of a class that holds a single instance
        /// singleton class. Instance initialization is lazy - i.e.
        /// will only be executed on the first call.
        /// This construction also guarantees that when accessed from multiple threads,
        /// only one instance of the class is created.
        /// </summary>
        private static readonly Lazy<FileWorkerSingleton> instance =
            new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton());

        /// <summary>
        /// Public property for accessing an instance of the singleton class.
        /// </summary>
        public static FileWorkerSingleton Instance { get { return instance.Value; } }

        /// <summary>
        /// The path to the recording file.
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// The contents of the file in dynamic memory.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// To prevent the user of the class from being able to create
        /// new instances of the constructor class must be made private.
        /// </summary>
        private FileWorkerSingleton()
        {
            FilePath = "test2.txt";
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
