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
            Regex mood = new Regex(MoodPattern.sadmood);
                      string mymood = this.mood;

            try
            {       if (mymood == null)
                { throw new MoodAnalysisException(); }

                     if (mood.IsMatch(mymood.ToLower()))
                     {
                        return "SAD";
                     }
                     else
                     {
                        return "HAPPY";

                     }
                
            }
            catch (MoodAnalysisException )
            {
                return "nullmood";
                

            }




        }

    }
}
