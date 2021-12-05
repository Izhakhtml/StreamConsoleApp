using SeriesConsoleApp;
// exe 1
List<Series> seriesList = new List<Series>();
 void SeriesManagment()
{
    Console.WriteLine("Add series tap 1");
    Console.WriteLine("Present series tap 2");
    Console.WriteLine("Present all series tap 3");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            int counter = 0;
            while (counter < 3)
            {  
            Series newSeries = new Series(); 
            Console.WriteLine("Enter the genre:");
            newSeries.genre = Console.ReadLine();
            Console.WriteLine("Enter the number of episode:");
            newSeries.numberEpisode = int.Parse(Console.ReadLine());
            
            FileStream fs = new FileStream(@$"C:\series\{newSeries.genre}.txt", FileMode.CreateNew);
            using(StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine($"{newSeries.genre}\n{newSeries.numberEpisode}");
            }
            FileStream fss = new FileStream(@$"C:\series\all-movies.txt", FileMode.Append);
            using(StreamWriter writerr = new StreamWriter(fss))
            {
                writerr.WriteLine($"Moviee name:{newSeries.genre}\nNumber episode:{newSeries.numberEpisode}");
            }
            seriesList.Add(newSeries);
            counter++;
            }
            SeriesManagment();
            break;
        case 2:
            string userInput = Console.ReadLine();
            //by list
            int i = 0;
            while (i < seriesList.Count)
            {
                if (userInput == seriesList[i].genre)
                {
                    Console.WriteLine($"Moviee name:{seriesList[i].genre}\nNumber episode:{seriesList[i].numberEpisode}");
                    break;
                }
                i++;
            }

            //by StreamReader
            FileStream fs2 = new FileStream(@$"C:\series\{userInput}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fs2))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            break;
        case 3:

            // by list
            //int x = 0;
            //while (x < seriesList.Count)
            //{
            //    Console.WriteLine($"Moviee name:{seriesList[x].genre}\n Number episode:{seriesList[x].numberEpisode}");
            //    x++;
            //}

            // by StreamReader
            FileStream fs3 = new FileStream(@"C:\series\all-movies.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fs3))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            break;
        case 4:
            string userInput2 = Console.ReadLine();
            int y = 0;
            while (y < seriesList.Count)
            {
                if (userInput2 == seriesList[y].genre)
                {

                    FileStream fs34 = new FileStream(@$"C:\series\{userInput2}.txt", FileMode.Create);
                    using (StreamWriter writerrr = new StreamWriter(fs34))
                    {
                    writerrr.WriteLine($"Moviee name:{seriesList[y].genre}\nNumber episode:{seriesList[y].numberEpisode + 1}");
                    }
                    //Console.WriteLine($"Moviee name:{seriesList[y].genre}\nNumber episode:{seriesList[y].numberEpisode + 1}");
                    //break;
                }
                y++;
          }
    break;
        default:
            Console.WriteLine("error");
            break;
    }
}
SeriesManagment();
void 