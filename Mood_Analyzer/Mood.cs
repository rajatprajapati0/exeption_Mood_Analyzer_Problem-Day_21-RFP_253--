using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mood_Analyzer
{
    public class MoodPattern
    {
        public static string sadmood = @"^(sad|i am sad|sad mood|i am in sad mood)$";

    }

    public class Mood
    {

        public string mood;

        public Mood()
        {
            mood = " ";
        }

        public Mood(string mood)
        {
            this.mood = mood;

        }

        public string checkMood()
        {
            Regex mood1 = new Regex(MoodPattern.sadmood);
            string mymood=this.mood;
            if (mood1.IsMatch(mymood.ToLower()))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";

            }
        }

    }
 }

