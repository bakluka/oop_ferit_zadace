using System;

namespace ClassLibrary_DZ1
{
    public class Episode
    {
        private int viewers;
        private double total_score;
        private double max_score;

        public Episode()
        {
            viewers = 0;
            total_score = 0;
            max_score = 0;
        }
        public Episode(int viewer_input, double total_score_input, double max_score_input)
        {
            viewers = viewer_input;
            total_score = total_score_input;
            max_score = max_score_input;
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

        public double GetAverageScore()
        {
            double average = total_score / viewers;
            return average;
        }

        public int GetViewerCount()
        {
            return viewers;
        }
    }
}
