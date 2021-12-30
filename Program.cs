// <copyright file="Program.cs" company="Alyona">
// Copyright (c) 2012 All Rights Reserved
// </copyright>

namespace Programm5
{
   using System;
   using System.Collections.Generic;
   using System.Diagnostics;
   using System.IO;

   /// <summary>
   /// Program Class. 
   /// </summary>
   public class Program
   {
      /// <summary>
      /// Main Method.
      /// </summary>
      public static void Main()
      {
         var words = ReadWords();
         var timelist = WatchList(words);
         var timelinkedlist = WatchLinkedList(words);
         Console.WriteLine(timelist.ToString() + " мс");
         Console.WriteLine(timelinkedlist.ToString() + " мс");
      }

      /// <summary>
      /// Reading the file.
      /// </summary>
      /// <returns>Array of words from the text.</returns>
      public static string[] ReadWords()
      {
         string text = File.ReadAllText("C:/Text1.txt");
         char[] delimiters = new char[] { ' ', '\r', '\n' };
         var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
         return words;
      }

      /// <summary>
      /// Using List.
      /// </summary>
      ///  /// <param name="words">Array of words.</param>
      /// <returns>Program runtime.</returns>
      public static double WatchList(string[] words)
      {
         var watch = Stopwatch.StartNew();
         var list = new List<string>();
         foreach (var word in words)
         {
            list.Add(word);
         }

         return watch.Elapsed.TotalMilliseconds;
      }

      /// <summary>
      /// Using LinkedList.
      /// </summary>
      ///  /// <param name="words">Array of words.</param>
      /// <returns>Program runtime.</returns>
      public static double WatchLinkedList(string[] words)
      {
         var watch = Stopwatch.StartNew();
         var list = new LinkedList<string>();
         foreach (var word in words)
         {
            list.AddFirst(word);
         }

         return watch.Elapsed.TotalMilliseconds;
      }
   }
}