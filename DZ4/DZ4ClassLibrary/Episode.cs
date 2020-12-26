using System;
namespace DZ4ClassLibrary
{
    public class Episode
    {
        private int viewers;
        private double total_score;
        private double max_score;
        private int number_purpose_of_which_evades_me; //nisam napravio drugu zadacu, nisam mogao iz konteksta shavtiti što predstavlja ovaj broj
        TimeSpan length;
        string title; 

        public Episode(int viewer_input, double total_score_input, double max_score_input, int number_purpose_of_which_evades_me, TimeSpan length, string title)
        {
            viewers = viewer_input;
            total_score = total_score_input;
            max_score = max_score_input;
            this.number_purpose_of_which_evades_me = number_purpose_of_which_evades_me;
            this.length = length;
            this.title = title; 
        }

        public void AddView(double score_to_add)
        {
            viewers++;
            total_score += score_to_add;
            if (score_to_add > max_score)
            {
                max_score = score_to_add;
            }
        }
        public double GetMaxScore()
        {
            return max_score;
        }

        public double GetTotalScore()
        {
            return total_score;
        }

        public string GetTitle()
        {
            return title; 
        }

        public double GetAverageScore()
        {
            double average = total_score / viewers;
            return average;
        }

        public int GetViewerCount()
        {
            return viewers;
        }

        public int GetTheNumber()
        {
            return number_purpose_of_which_evades_me;
        }

        public TimeSpan GetDuration()
        {
            return length;
        }
    }
}
