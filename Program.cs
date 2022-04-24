string path = @"c:\Users\Admin\Downloads\30da91a108";

DirectoryInfo di = new DirectoryInfo(path);

long fileSize = 0;

try
{
    if (di.Exists)
    {
        var allFilesPaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        foreach (var filePath in allFilesPaths)
        {
            if (File.Exists(filePath))
            {
                var file = new FileInfo(filePath);

                fileSize += file.Length;
            }
            else
                Console.WriteLine($"Некорректный путь файла '{filePath}'!");
        }

        Console.WriteLine($"Размер всех файлов в каталоге: {fileSize} b");
    }
    else
        Console.WriteLine("Некорректный путь!");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка! {ex.Message}");
}
