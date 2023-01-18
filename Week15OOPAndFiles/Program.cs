
List<Movie> myMovie = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromeArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie  newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovie.Add(newMovie);
}

foreach(Movie movie in myMovie)
{
    Console.WriteLine($"One of my favorite movies {movie.Title}was realased in {movie.Year}.");

}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Data\movies.txt";
    //string[] dataFromFile= File.ReadAllLines(filePath);
    return File.ReadAllLines(filePath) ;
}
static void ReadDataFromeArray(string[] someArray)
{
    foreach(string line in someArray )
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;// filds
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    public Movie (string _title, string _year)
    {
        title = _title;
        year = _year;
    }

}






























