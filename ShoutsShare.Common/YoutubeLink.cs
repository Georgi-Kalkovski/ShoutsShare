namespace ShoutsShare.Common
{
    using System;
    using System.IO;

    public class YoutubeLink
    {
        public string Youtube()
        {
            string[] lines = File.ReadAllLines("D:\\Coding\\SoftUni\\Shouts-Share\\ShoutsShare.Common\\YoutubeIDs.txt");
            Random rand = new Random();
            var link = "https://www.youtube.com/embed/" + lines[rand.Next(lines.Length)];
            return link;
        }
    }
}
