using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDZ3
{
    public class Season
    {
        int number;
        Episode[] episodes;
        public Season(int number, Episode[] episodes)
        {
            this.number = number;
            this.episodes = episodes;
        }
        
        public int Length { get => episodes.Length; }

        public Episode this[int wordIndex]
        {
            get { return episodes[wordIndex]; }
            set { episodes[wordIndex] = value; }
        }
        public override string ToString()
        {
            string[] episode_print = new string[episodes.Length+7]; // 7 ekstra linija mimo samih epizoda u formatu ispisa
            string graph_separator = "=================================================";
            TimeSpan total_length = TimeSpan.Zero;
            int total_viewers = 0;

            episode_print[0] = $"Season {number}:";
            episode_print[1] = graph_separator;
            for (int i = 2; i < episodes.Length+2; i++)
            {
                Episode ep = episodes[i-2];
                total_length += ep.GetDuration();
                total_viewers += ep.GetViewerCount();
                episode_print[i] = $"{ep.GetViewerCount()},{Math.Round(ep.GetAverageScore(), 2)},{Math.Round(ep.GetMaxScore(),2)},{ep.GetTheNumber()},{ep.GetDuration().ToString()},{ep.GetTitle()}";
            }
            episode_print[2+episodes.Length] = "Report: ";
            episode_print[3 + episodes.Length] = graph_separator;
            episode_print[4 + episodes.Length] = $"Total viewers: {total_viewers}";
            episode_print[5 + episodes.Length] = $"Total duration: {total_length.ToString()}";
            episode_print[6 + episodes.Length] = graph_separator;

            return String.Join("\n", episode_print)+"\n";
        }

    }

}
