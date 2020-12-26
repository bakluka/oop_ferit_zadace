using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DZ4ClassLibrary
{
    public class Season : IEnumerable
    {
        int number;
        List<Episode> episodes;

        public Season(int number, List<Episode> episodes)
        {
            this.number = number;
            this.episodes = episodes;
        }

        public Season(Season copy)
        {
            this.number = copy.number;
            episodes = copy.episodes.ConvertAll(ep => new Episode(ep.GetViewerCount(), ep.GetTotalScore(), ep.GetMaxScore(), ep.GetTheNumber(), ep.GetDuration(), ep.GetTitle()));
        }

        public int Length { get => episodes.Count; }

        public Episode this[int index] { get => episodes[index]; set => episodes[index] = value; }
        public override string ToString()
        {
            string[] episode_print = new string[episodes.Count + 7]; // 7 ekstra linija mimo samih epizoda u formatu ispisa
            string graph_separator = "=================================================";
            TimeSpan total_length = TimeSpan.Zero;
            int total_viewers = 0;

            episode_print[0] = $"Season {number}:";
            episode_print[1] = graph_separator;
            for (int i = 2; i < episodes.Count + 2; i++)
            {
                Episode ep = episodes[i - 2];
                total_length += ep.GetDuration();
                total_viewers += ep.GetViewerCount();
                episode_print[i] = $"{ep.GetViewerCount()},{Math.Round(ep.GetAverageScore(), 2)},{Math.Round(ep.GetMaxScore(), 2)},{ep.GetTheNumber()},{ep.GetDuration().ToString()},{ep.GetTitle()}";
            }
            episode_print[2 + episodes.Count] = "Report: ";
            episode_print[3 + episodes.Count] = graph_separator;
            episode_print[4 + episodes.Count] = $"Total viewers: {total_viewers}";
            episode_print[5 + episodes.Count] = $"Total duration: {total_length.ToString()}";
            episode_print[6 + episodes.Count] = graph_separator;

            return String.Join("\n", episode_print) + "\n";
        }

        public void Remove(string title)
        {
            var result = episodes.Find(e => e.GetTitle().ToLower() == title.ToLower());
            if (!episodes.Remove(result))
            {
                throw new TvException("No such episode found.", title);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < episodes.Count; index++)
            {
                yield return episodes[index];
            }
        }
    }
}
