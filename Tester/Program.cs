﻿using System.IO;
using System.Runtime;
using System.Text.RegularExpressions;
using System.Linq;
using AuATIS.Client;
using System.Collections.Specialized;
using System.Reflection.Metadata;

namespace AuATIS.Tester
{
    public class Program
    {
        public static Api ApiObject;

        public static void Main(string[] args)
        {
            string Profile = "Australia";
            ApiObject = new Api();

            ApiObject.GetStatus();


            //string MetarResult = GetMETAR("YMML").Result;
            Console.ReadLine();
        }

        static string MatchClouds(string METAR)
        {
            string[] Matches =  Regex.Matches(METAR, @"([A-Z]{3}\d{3})").Cast<Match>().Select(m => m.Value).ToArray<string>();
            return string.Join(" ", Matches);
        }

        static string MatchWind(string METAR)
        {
            string result;
            string[] Matches = Regex.Matches(METAR, @"(\d{5}KT)|(\d{5}G\d{2}KT)|(VRB\d{2}KT)|(VRB\d{2}G\d{2}KT)").Cast<Match>().Select(m => m.Value).ToArray<string>(); // (\d{5}KT.\d{3}V\d{3})|(\d{5}G\d{2}KT.\d{3}V\d{3})|(VRB\d{2}KT.\d{3}V\d{3})|(VRB\d{2}G\d{2}KT.\d{3}V\d{3}) regex to match varwinds 
            string intermediate = string.Join(" ", Matches).Insert(3, "/").Replace('G', '-');
            if (intermediate.Contains("V"))
            {
                char[] delims = { ' ', 'V' };
                string[] ISplit = intermediate.Split(delims); // 240 11KT 230V250
                
                result = string.Concat(ISplit);
            } else
            {
                result = intermediate;
            }
            return result;
        }

        static string MatchVisibility(string METAR)
        {
            string[] Matches = Regex.Matches(METAR, @"(\d{4})").Cast<Match>().Select(m => m.Value).ToArray<string>();
            return string.Join(" ", Matches);
        }

        static string MatchTempDP(string METAR)
        {
            string[] Matches = Regex.Matches(METAR, @"(\d{2}\/\d{2})|(M\d{2}\/\d{2})|(M\d{2}\/M\d{2})").Cast<Match>().Select(m => m.Value).ToArray<string>();
            return string.Join(" ", Matches);
        }
        static string MatchQNH(string METAR)
        {
            string[] Matches = Regex.Matches(METAR, @"(Q\d{4})").Cast<Match>().Select(m => m.Value).ToArray<string>();
            return string.Join(" ", Matches);
        }
        static string MatchAltimeter(string METAR)
        {
            string[] Matches = Regex.Matches(METAR, @"(A\d{4})").Cast<Match>().Select(m => m.Value).ToArray<string>();
            return string.Join(" ", Matches);
        }
    } 
}